/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * Chapter 5.13 Strings                                              *
 *                                                                   *
 * Copyright © 2018 Alex Okita                                       *
 *                                                                   *
 * This software may be modified and distributed under the terms     *
 * of the MIT license.  See the LICENSE file for details.            *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
namespace Chapter5_13
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Strings : MonoBehaviour
    {
        #region Chapter 5.13.1.1 Strings - A Basic Example
        /* * * * * * * * * * * * * * * * * * * * * * * * *
         * Section 5.13.1.1 Strings -  A Basic Example   *
         * * * * * * * * * * * * * * * * * * * * * * * * */
        void UseStrings()
        {
            /*
             * Section 5.13.1.1 Strings - A Basic Example
             */
            string s = "Something in quotes.";
            Debug.Log(s);
            s += "more words.";
            Debug.Log(s);
            bool hasSomething = s.Contains("Something");
            Debug.Log(hasSomething);
            s = "First Word " + "Second Word";
            Debug.Log(s);
            //s = "First Word " - "Second Word";
            /*
             * Uncomment the line above to see
             * the error.
             */
        }
        #endregion

        #region Chapter 5.13.2 Escape Sequences
        /* * * * * * * * * * * * * * * * * * * * * * * * *
         * Section 5.13.2 Escape Sequences               *
         * * * * * * * * * * * * * * * * * * * * * * * * */
        void UseEscapeSequences()
        {
            /*
             * Section 5.13.2 Escape Sequences
             */
            //string s = "test a
            //line return";
            /*
             * uncomment the two lines
             * above to see the multiple
             * errors that it creates.
             */
            string s = "First line. \n Second Line";
            Debug.Log(s);
            Debug.Log("\"I Want Quotes!\"");
            s = "This\nThat";
            Debug.Log(s);
            s = @"This\nThat";
            Debug.Log(s);
            s = @"this
that and
the other";
            Debug.Log(s);
        }
        /*
         *    \a  (beep)
         *    \b  Backspace
         *    \f  Formfeed
         *    \n  New line
         *    \r  Carriage return
         *    \t  Tab
         *    \v  Vertical tab
         *    \'  Single quote
         *    \"  Double quote
         *    \\  Backslash
         *    \?  Literal question mark
         */
        #endregion

        void Start()
        {
            /* * * * * * * * * * * * * * * * * * * * * * * * *
             * Section 5.13.1.1 Strings -  A Basic Example   *
             * * * * * * * * * * * * * * * * * * * * * * * * */
            UseStrings();

            /* * * * * * * * * * * * * * * * * * * * * * * * *
             * Section 5.13.2 Escape Sequences               *
             * * * * * * * * * * * * * * * * * * * * * * * * */
            UseEscapeSequences();
        }
    }
}
