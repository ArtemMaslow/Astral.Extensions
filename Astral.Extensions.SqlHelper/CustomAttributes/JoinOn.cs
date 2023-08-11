using System;
using System.Collections.Generic;
using System.Text;

namespace Astral.Extensions.SqlHelper.CustomAttributes
{
    public class JoinOn : Attribute
    {
        private string _leftPart;
        private string _rightPart;

        public JoinOn(string leftPart, string rightPart)
        {
            _leftPart = leftPart;
            _rightPart = rightPart;
        }

        public string LeftPart => _leftPart;
        public string RightPart => _rightPart;
    }
}
