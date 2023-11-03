using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageViewerAndMangementTool.Models
{
    public class FileInformation
    {
        public bool Mark { get; set; } =false;
        public string? FileName { get; set; }
        public string? Path { get; set; }
        public string? Extension { get; set; }

    }
}
