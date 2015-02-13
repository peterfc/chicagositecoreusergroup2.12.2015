using System;
using System.Web.Services;
using Models.News;

namespace Website
{
    /// <summary>
    /// Summary description for NewsWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class NewsWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public ArticleFromWebService[] GetNews()
        {
            return new []
            {
                new ArticleFromWebService
                {
                    Author = "Jane Smith",
                    Body = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. In ornare dui vel mi eleifend consequat at eu mauris. Nam mattis vel eros eget blandit. Sed sem arcu, consequat eget scelerisque commodo, lacinia vel tellus. Nullam nec posuere mauris. Sed maximus diam viverra viverra molestie. Proin in leo mollis orci tempus condimentum. Curabitur mollis enim et congue ullamcorper.</p><p>Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Mauris ullamcorper, purus sed egestas consectetur, dolor ex tempus metus, et scelerisque libero quam nec justo. Integer ut faucibus risus. Nullam porta ex vel commodo congue. Phasellus imperdiet malesuada interdum. Aenean feugiat sapien sed malesuada fermentum. Quisque ornare metus lorem, sed dignissim metus convallis sed. Morbi vehicula ante scelerisque massa gravida tristique. Proin aliquet lectus congue dapibus semper. Aliquam ut luctus eros. Aliquam posuere orci a aliquet malesuada.</p><p>Duis egestas laoreet semper. Aenean suscipit imperdiet tincidunt. Donec laoreet ultricies sem sit amet interdum. Praesent hendrerit quis justo vitae eleifend. Aliquam interdum nisl nulla, sit amet pretium sapien luctus ut. Nam nec ex erat. Nulla faucibus arcu et turpis porttitor, ac tristique ante ornare. Cras urna ligula, feugiat sit amet laoreet ut, placerat et dui. Donec fringilla orci nec elit tempor mollis.</p>",
                    Headline = "News Article from Web Service",
                    PublishDate = DateTime.Now.AddDays(-90)
                },
                new ArticleFromWebService
                {
                    Author = "John Doe",
                    Body = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. In ornare dui vel mi eleifend consequat at eu mauris. Nam mattis vel eros eget blandit. Sed sem arcu, consequat eget scelerisque commodo, lacinia vel tellus. In nisi velit, malesuada at varius sit amet, porttitor vitae sapien. Proin in leo mollis orci tempus condimentum. Curabitur mollis enim et congue ullamcorper.</p><p>Mauris ac ex felis. Maecenas ac luctus odio. Nunc laoreet lorem dignissim urna blandit, sit amet gravida nibh dignissim. Integer volutpat pellentesque tempus. Nunc porta libero ex. Aliquam commodo massa quis tortor vehicula tempor. Etiam tellus mauris, condimentum vitae blandit ut, blandit et lorem. Morbi massa justo, tincidunt eget mi et, rutrum lacinia libero.</p>",
                    Headline = "2nd News Article from Web Service",
                    PublishDate = DateTime.Now.AddDays(-30)
                }
            };
        }
    }
}
