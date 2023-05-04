using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCounter
{
    public class PlayerModel
    {
        public string PLAY_ID {  get; set; }
        public int SONG_ID { get; set; }
        public int CLIENT_ID { get; set; }
        public DateTime PLAY_TS { get; set;}
    }
}
