﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MICROPHONE
{
    class EqualizerHandler : ViewModelBase
    {
        
        private Equali equalizer;
        private EqualizerBand[] bands;

        public EqualizerHandler()
        {
            
            bands = new EqualizerBand[]
                    {
                        new EqualizerBand {Bandwidth = 0.8f, Frequency = 100, Gain = 0},
                        new EqualizerBand {Bandwidth = 0.8f, Frequency = 200, Gain = 0},
                        new EqualizerBand {Bandwidth = 0.8f, Frequency = 400, Gain = 0},
                        new EqualizerBand {Bandwidth = 0.8f, Frequency = 800, Gain = 0},
                        new EqualizerBand {Bandwidth = 0.8f, Frequency = 1200, Gain = 0},
                        new EqualizerBand {Bandwidth = 0.8f, Frequency = 2400, Gain = 0},
                        new EqualizerBand {Bandwidth = 0.8f, Frequency = 4800, Gain = 0},
                        new EqualizerBand {Bandwidth = 0.8f, Frequency = 9600, Gain = 0},
                    };
            //when changing the gain in the bands ( trackBars)
            this.PropertyChanged += OnPropertyChanged;
        }

        public EqualizerBand[] Bands
        {
            set { bands = value; }
            get { return bands; }
        }
        public Equali SongEqualizer
        {
            set { equalizer = value; }
            get { return equalizer; }
        }

        public float Band1
        {
            get { return bands[0].Gain; }
            set
            {
                if (bands[0].Gain != value)
                {
                    bands[0].Gain = value;
                    OnPropertyChanged("Band1");
                   

                }
            }
        }

        public float Band2
        {
            get { return bands[1].Gain; }
            set
            {
                if (bands[1].Gain != value)
                {
                    bands[1].Gain = value;
                    OnPropertyChanged("Band2");

                }
            }
        }

        public float Band3
        {
            get { return bands[2].Gain; }
            set
            {
                if (bands[2].Gain != value)
                {
                    bands[2].Gain = value;
                    OnPropertyChanged("Band3");
                   
                }
            }
        }

        public float Band4
        {
            get { return bands[3].Gain; }
            set
            {
                if (bands[3].Gain != value)
                {
                    bands[3].Gain = value;
                    OnPropertyChanged("Band4");
                    
                }
            }
        }

        public float Band5
        {
            get { return bands[4].Gain; }
            set
            {
                if (bands[4].Gain != value)
                {
                    bands[4].Gain = value;
                    OnPropertyChanged("Band5");
                    
                }
            }
        }

        public float Band6
        {
            get { return bands[5].Gain; }
            set
            {
                if (bands[5].Gain != value)
                {
                    bands[5].Gain = value;
                    OnPropertyChanged("Band6");
                    
                }
            }
        }


        public float Band7
        {
            get { return bands[6].Gain; }
            set
            {
                if (bands[6].Gain != value)
                {
                    bands[6].Gain = value;
                    OnPropertyChanged("Band7");
                   
                }
            }
        }

        public float Band8
        {
            get { return bands[7].Gain; }
            set
            {
                if (bands[7].Gain != value)
                {
                    bands[7].Gain = value;
                    OnPropertyChanged("Band7");
                  
                }
            }
        }





        private void OnPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (equalizer != null) equalizer.Update();

           
        }
    }
}
