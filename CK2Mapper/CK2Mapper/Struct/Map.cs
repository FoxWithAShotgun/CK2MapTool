using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK2Mapper.Struct
{
    /// <summary>
    /// The Map class contains every piece of information relating to the map and its layout.
    /// </summary>
    public class Map
    {
        public Dictionary<int, Province> Provinces = new Dictionary<int, Province>();

        /// <summary>
        /// Generates a new Map from a given mod directory.
        /// While not all files are necessary to build a map, there are a few minimum items that are actually required:
        /// - map\definition.csv
        /// - map\provinces.bmp
        /// - map\default.map
        /// Without these, a proper map cannot be generated.
        /// Some files are optional and add more information to the map file:
        /// - map\adjacencies.csv
        /// - map\island_region.txt
        /// - map\geographical_region.txt
        /// - map\continent.txt
        /// </summary>
        /// <param name="modDirectory"></param>
        public Map (String modDirectory)
        {
            // Attempt to read in definition.csv to generate a dictionary of all provinces.
            // This file is in <dir>/map/.
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(modDirectory + "\\map\\definition.csv");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
    }
}
