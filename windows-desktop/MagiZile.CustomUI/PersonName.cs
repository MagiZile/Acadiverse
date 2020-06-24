using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagiZile.CustomUI
{
    public struct PersonName
    {
        public string first;
        public string nickname;
        public string middle;
        public string last;

        public PersonName(string first, string last)
        {
            this.first = first;
            nickname = "";
            middle = "";
            this.last = last;
        }

        public PersonName(string first, string middle, string last)
        {
            this.first = first;
            nickname = "";
            this.middle = middle;
            this.last = last;
        }

        public PersonName(string first, string nickname, string middle, string last)
        {
            this.first = first;
            this.nickname = nickname;
            this.middle = middle;
            this.last = last;
        }

        public override string ToString()
        {
            string value = first;
            if (nickname != "")
            {
                value += " \"" + nickname + "\"";
            }
            if (middle != "")
            {
                value += " " + middle;
            }
            value += " " + last;
            return value;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(PersonName))
            {
                return false;
            }
            else
            {
                PersonName other = (PersonName)obj;
                return first.Equals(other.first) && nickname.Equals(other.nickname) && middle.Equals(other.middle) && last.Equals(other.last);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}