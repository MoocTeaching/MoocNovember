using Mooc.DataAccess.Entities;
using Mooc.DataAccess.Service;
using Mooc.Models.Dtos.User;
using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Mooc.Web.Controllers
{
    public class UsersController : Controller
    {
        //private DataContext db = new DataContext();
        private IUserService _userService;
        public UsersController(IUserService userService)
        {
            this._userService = userService;
        }

        // GET: Users
        public ActionResult Index()
        {
            var list = _userService.GetList();

            return View(list);
        }

        // GET: Users/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (!id.HasValue)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var user = await this._userService.GetUser(id.Value);

            if (user == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);

            }
            //var list = _userService.GetList();

            //UserDto user = list.Find(a => a.Id == id);
            return View(user);
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,UserName,PassWord,Email,UserState,RoleType,AddTime")] CreateOrUpdateUserDto user)
        {
            if (ModelState.IsValid)
            {
                this._userService.Add(user);
            }

            return View(user);
        }

        // GET: Users/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //User user = await db.Users.FindAsync(id);
            //if (user == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(user);

            return View();
        }

        // POST: Users/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,UserName,PassWord,Email,UserState,RoleType,AddTime")] UserDto user)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //User user = await db.Users.FindAsync(id);
            //if (user == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(user);

            return View();

        }

        // GET: Users/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //User user = await db.Users.FindAsync(id);
            //if (user == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(user);

            return View();
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            //User user = await db.Users.FindAsync(id);
            //db.Users.Remove(user);
            //await db.SaveChangesAsync();
            //return RedirectToAction("Index");

            return View();
        }
    }
}