using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotePade.Model;
using NotePade.View;

namespace NotePade.Presenters
{
    class PagePresenter
    {
        IPage PageView;

        public PagePresenter(IPage view)
        {
            PageView = view;
        }
        public void CalculateArea()
        {
            PageModel page = new PageModel();
            page.content = PageView.PContent;

            PageView.PContent = page.PageContent().ToString();
        }
    }

}
