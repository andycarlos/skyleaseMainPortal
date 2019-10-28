using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Serialization;
using Skylease.Models;
using ServiceReference1;

namespace Skylease.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrakingController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Traking> getTraking([FromQuery] string trak)
        {
            Traking traking = new Traking();

            WsUtilSoapClient wsUtilSoapClient = new WsUtilSoapClient(WsUtilSoapClient.EndpointConfiguration.WsUtilSoap);
            ArrayOfXElement a = wsUtilSoapClient.getTrackingAsync(trak).Result;
            ArrayOfXElement b = wsUtilSoapClient.getTrackAwbAsync(trak).Result;
            ArrayOfXElement c = wsUtilSoapClient.getAgentSimpleAsync(trak, "#@io(*^^!jl").Result;

            if (a.Nodes.Count == 2 && b.Nodes.Count == 2 && c.Nodes.Count == 2)
            {
                //awb
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Models.awb.diffgram));
                Models.awb.diffgram awb = (Models.awb.diffgram)xmlSerializer.Deserialize(b.Nodes[1].CreateReader());
                //trakiing
                XmlSerializer xmlSerializer1 = new XmlSerializer(typeof(Models.trakingHistory.diffgram));
                Models.trakingHistory.diffgram trakin = (Models.trakingHistory.diffgram)xmlSerializer1.Deserialize(a.Nodes[1].CreateReader());
                //agent
                XmlSerializer xmlSerializer2 = new XmlSerializer(typeof(Models.agent.diffgram));
                Models.agent.diffgram agent = (Models.agent.diffgram)xmlSerializer2.Deserialize(c.Nodes[1].CreateReader());

                List<Models.trakingHistory.NewDataSetTable> trakings = trakin.NewDataSet.OrderByDescending(x => x.DATEIN).ToList();

                traking = new Traking()
                {
                    Name = agent.NewDataSet.Table.Name.Trim(),
                    Origin = awb.NewDataSet.Table.origin.Trim(),
                    Destination = awb.NewDataSet.Table.destination.Trim(),
                    CargoType = "GENERAL",
                    Pieces = awb.NewDataSet.Table.totpieces.ToString(),
                    Weight = Math.Round(awb.NewDataSet.Table.totweight,0).ToString(),
                    Volumen =Math.Round(awb.NewDataSet.Table.totvolume,0).ToString(),
                    TrakingHistors = trakings.Select(x => new TrakingHistor()
                    {
                        date = x.DATEIN,
                        Note = x.NOTE.Trim(),
                        Pieces = x.PIECES.ToString(),
                        Weight = x.WEIGHT.ToString()

                    }).ToList()
                };
            }
            return Ok(traking);
        }
    }
}