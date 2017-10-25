using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht1
{
    public partial class Opiskelija : Component
    {
        public Opiskelija()
        {
            InitializeComponent();
        }

        public Opiskelija(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
