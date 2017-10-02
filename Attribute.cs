using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGBase
{
    public sealed class Attribute
    {
        /// <summary>
        /// the <see cref="Attribute"/> 's name abbreviation.
        /// </summary>
        private string abbr;
        /// <summary>
        /// the <see cref="Attribute"/> 's base value.
        /// </summary>
        private float baseVal;
        /// <summary>
	    /// the <see cref="Attribute"/> 's description.
        /// </summary>
	    private string description;
        /// <summary>
        /// the <see cref="Attribute"/> 's display name.
        /// </summary>
        private string displayName;
        /// <summary>
        /// the value of any modifiers to the attribute.
        /// </summary>
        private float modifier;
        /**
         * Creates a new instance of {@link Attribute}.
         * @param a the {@link Attribute}'s name abbreviation
         * @param n the {@link Attribute}'s display name
         */
        public Attribute(string a, string n) : this(a, n, null)
        {
        }
        /// <summary>
        /// Creates a new instance of <see cref="Attribute"/>.
        /// <param name="a">the <see cref="Attribute"/>'s name abbreviation</param>
        /// <param name="n">the <see cref="Attribute"/>'s display name</param>
        /// <param name="desc">the <see cref="Attribute"/>'s description</param>
        /// </summary>
        public Attribute(string a, string n, string desc)
        {
            abbr = a;
            displayName = n;
            description = desc;
        }
    }
}
