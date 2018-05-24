using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    class RankedGradeBooks : BaseGradeBook
    {

        public RankedGradeBooks(string name) : base(name)
        {
            this.Name = name;
            this.Type = GradeBookType.Ranked;
        }

    }
}
