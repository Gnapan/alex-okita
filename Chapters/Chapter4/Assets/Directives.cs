/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * Chapter 4.5 Directives                                            *
 *                                                                   *
 * Copyright © 2018 Alex Okita                                       *
 *                                                                   *
 * This software may be modified and distributed under the terms     *
 * of the MIT license.  See the LICENSE file for details.            *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
namespace Chapter4_5
{
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;

    using UnityEngine;
    using System;

    public class Directives : MonoBehaviour
    {
        void Start()
        {
            #region Chapter 4.5.1 Libraries
            /* * * * * * * * * * * * * * *
             * Seciton 4.5.1 Libraries   *
             * * * * * * * * * * * * * * */

            StreamWriter writer = new StreamWriter("MyFile.txt");
            writer.WriteLine("This is a new file...");
            writer.Flush();

            /* StreamWriter lives in System.IO
             * your options are to use
             * System.IO.StreamWriter writer = new System.IO.StreamWriter("MyFile.txt");
             * or add
             * using System.IO; to the top of this script
             * then you can use
             * StreamWriter writer = new StreamWriter("MyFile.txt");
             * 
             * If you like, delete the MyFile.txt in the project directory.
             * Come back here, change the text in the WriteLine function.
             * run the game in editor.
             * then check out the new MyFile.txt that was written.
             */
            #endregion

            #region Chapter 4.5.2 Ambiguous Namespaces
            /* * * * * * * * * * * * * * * * * * * * *
             * Section 4.5.2 Ambiguous Namespaces    *
             * * * * * * * * * * * * * * * * * * * * */

            int randUnity = UnityEngine.Random.Range(0, 10);

            //int rand = Random.Range(0, 10);

            /* Uncomment the line above to see the error
             * Adding using System; to the header
             * changes Random.Range(0, 10); from
             * valid to having a name space conflict!
             */
            #endregion
        }
    }
}
