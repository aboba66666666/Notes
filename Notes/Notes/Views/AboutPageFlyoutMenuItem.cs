using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Views
{
    public class AboutPageFlyoutMenuItem
    {
        public AboutPageFlyoutMenuItem()
        {
            TargetType = typeof(AboutPageFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}