using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPSoundBoard.Model
{
    internal class SoundManager
    {
        public void GetAllSounds(ObservableCollection<Sound> sounds)
        {
            var allSounds = getSounds();
            sounds.Clear();

            allSounds.ForEach(sound => sounds.Add(sound));
        }
        private List<Sound> getSounds()
        {
            return new List<Sound>
            {
                new Sound("Cat", SoundCategory.Animals),
                new Sound("Cow", SoundCategory.Animals),
                new Sound("Gun", SoundCategory.Cartoons),
                new Sound("Spring", SoundCategory.Cartoons),
                new Sound("Clock", SoundCategory.Taunts),
                new Sound("LOL", SoundCategory.Taunts),
                new Sound("Ship", SoundCategory.Warnings),
                new Sound("Siren", SoundCategory.Warnings)
            };
        }
    }
}
