﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrakerLibrary.Models
{
    public    class MatchupEntryModel
    {
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represents one team in the matchup.
        /// </summary>
        public double Score { get; set; }
        public MatchupModel ParentMatchup { get; set; }

    }
}
