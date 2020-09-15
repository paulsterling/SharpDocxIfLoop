using System.Collections.Generic;

namespace SharpDocxIfLoop.Models
{
    public class Loop
    {
        public Loop()
        {
            LoopItems = new List<IfLoop>();
        }

        public List<IfLoop> LoopItems { get; set; }
    }


    public class IfLoop
    {
        public bool ShowText { get; set; }
        public string TextContent { get; set; }

    }
}
