using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Models;
using Umbraco.Web.PublishedModels;

namespace HorsensBoligudlejning.Controllers
{
    public class LedigeLejemalController : Umbraco.Web.Mvc.RenderMvcController
    {
        // GET: LedigeLejemal
        public override ActionResult Index(ContentModel cModel)
        {
            //Checks if 
            var model = new LedigeLejemal(cModel.Content);
            var contentService = Services.ContentService;
            var settings = (Indstillinger)model.AncestorOrSelf(1).Siblings<Indstillinger>().FirstOrDefault();

            foreach (Lejemal item in model.Children)
            {
                var node = contentService.GetById(item.Id);
                var expireDate = node.ContentSchedule.GetSchedule(ContentScheduleAction.Expire).Select(x => x.Date).OrderByDescending(o => o.Date).FirstOrDefault();

                if (expireDate == DateTime.MinValue && item.Ledig == false)
                {
                    var contentsched = new ContentSchedule("*", DateTime.Now.AddDays(settings.AntalDageForUdlejetLejlighedForsvinder), ContentScheduleAction.Expire);
                    node.ContentSchedule.Clear(ContentScheduleAction.Expire);
                    node.ContentSchedule.Add(contentsched);
                    contentService.SaveAndPublish(node);
                }
                else if (expireDate != DateTime.MinValue && item.Ledig == true)
                {
                    node.ContentSchedule.Clear(ContentScheduleAction.Expire);
                    contentService.SaveAndPublish(node);
                }
            }

            return base.Index(cModel);
        }
    }
}