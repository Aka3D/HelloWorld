using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Model
{
    public class EditformModel
    {
        public string Task { get; set; }
        public bool IsComplete { get; set; }
    }
}
