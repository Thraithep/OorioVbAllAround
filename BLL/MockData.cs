using ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MockData
    {
        public static List<Content> mockContent()
        {
            List<Content> res = new List<Content>();

            res.Add(new Content
            {
                Title = "Test1",
                Description = "Description1"
            });

            res.Add(new Content
            {
                Title = "Test2",
                Description = "Description2"
            });

            res.Add(new Content
            {
                Title = "Test3",
                Description = "Description3"
            });

            res.Add(new Content
            {
                Title = "Test4",
                Description = "Description4"
            });

            res.Add(new Content
            {
                Title = "Test5",
                Description = "Description5"
            });

            res.Add(new Content
            {
                Title = "Test6",
                Description = "Description6"
            });

            return res;
        }
    }
}
