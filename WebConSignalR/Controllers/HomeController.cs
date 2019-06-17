using Microsoft.AspNet.SignalR;
using System.Linq;
using System.Web.Mvc;
using WebConSignalR.Hubs;

namespace WebConSignalR.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            db_signalrEntities1 ctx = new db_signalrEntities1();
            ViewBag.Comentarios = ctx.Comentario.ToList();
            
            Comentario model = new Comentario();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(Comentario model)
        {
            db_signalrEntities1 ctx = new db_signalrEntities1();
            if (!ModelState.IsValid)
            {
                ViewBag.Comentarios = ctx.Comentario.ToList();
                return View(model);
            }
                       
            ctx.Comentario.Add(model);
            ctx.SaveChanges();

            IHubContext miHub = GlobalHost.ConnectionManager.GetHubContext<ComentariosHub>();
            miHub.Clients.All.addNewMessageToPage(model.usuario,model.texto);

            return Redirect("Index");
        }

        [HttpGet]
        public ActionResult SinSignal()
        {
            db_signalrEntities1 ctx = new db_signalrEntities1();
            ViewBag.Comentarios = ctx.Comentario.ToList();
            Comentario model = new Comentario();
            return View(model);
        }

        [HttpPost]
        public ActionResult SinSignal(Comentario model)
        {
            db_signalrEntities1 ctx = new db_signalrEntities1();
            if (!ModelState.IsValid)
            {
                ViewBag.Comentarios = ctx.Comentario.ToList();
                return View(model);
            }            
            ctx.Comentario.Add(model);
            ctx.SaveChanges();

            return Redirect("SinSignal");
        }
        

    }
}