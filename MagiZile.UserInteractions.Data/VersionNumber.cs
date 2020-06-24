using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagiZile.UserInteractions.Data
{
    public struct VersionNumber
    {
        public int major;
        public int minor;
        public int build;
        public int revision;
        public VersionNumber(int major, int minor, int build, int revision)
        {
            this.major = major;
            this.minor = minor;
            this.build = build;
            this.revision = revision;
        }

        public override string ToString()
        {
            return major + "." + minor + "." + build + "." + revision;
        }
    }
}