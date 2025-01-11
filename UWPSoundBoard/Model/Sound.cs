using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPSoundBoard.Model
{
    public enum SoundCategory
    {
        Animals,
        Cartoons,
        Taunts,
        Warnings
    }
    public class Sound
    {
        public string Name { get; set; }
        public SoundCategory SoundCategory { get; set; }
        public string AudioFile { get; set; }
        public string ImageFile { get; set; }

        public Sound(string name, SoundCategory category)
        {
            Name = name;
            SoundCategory = category;
            AudioFile = $"/Assets/Audio/{category}/{name}.wav";
            ImageFile = $"/Assets/Images/{category}/{name}.png";
        }
    }
}
