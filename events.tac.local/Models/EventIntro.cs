using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace events.tac.local.Models
{
    /// <summary>
    /// EventIntro Model
    /// </summary>
    public class EventIntro
    {
        /// <summary>
        /// ConTentHeading Prop
        /// </summary>
        public HtmlString ContentHeading { get; set; }

        /// <summary>
        /// ContentIntro Prop
        /// </summary>
        public HtmlString ContentIntro { get; set; }

        /// <summary>
        /// ContentBody Prop
        /// </summary>
        public HtmlString ContentBody { get; set; }

        /// <summary>
        /// EventImage Prop
        /// </summary>
        public HtmlString EventImage { get; set; }

        /// <summary>
        /// Highlights Prop
        /// </summary>
        public HtmlString Highlights { get; set; }

        /// <summary>
        /// StarDate Prop
        /// </summary>
        public HtmlString StartDate { get; set; }

        /// <summary>
        /// Duration Prop
        /// </summary>
        public HtmlString Duration { get; set; }

        /// <summary>
        /// DifficultyLevel Prop
        /// </summary>
        public HtmlString DifficultyLevel { get; set; }


    }
}