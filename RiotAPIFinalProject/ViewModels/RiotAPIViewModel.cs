﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.ChampionMasteryV4;
using MingweiSamuel.Camille.Enums;
using MingweiSamuel.Camille.MatchV5;
using MingweiSamuel.Camille.SummonerV4;

namespace RiotAPIFinalProject.ViewModels
{
    public class RiotAPIViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Summoner Summoner { get; set; }

        public ChampionMastery[] Masteries { get; set; }

        public BindingList<Champ> Champions { get; set; }

        public BindingList<Match> Matches { get; set; }

        public BindingList<MatchInfo> CurrentMatchInfo { get; set; }

        public BindingList<MatchMeta> CurrentMatchMeta { get; set; }

        public RiotApi RiotInfo
        {
            get => _riotAPI;
            set
            {
                if (_riotAPI != value)
                {
                    _riotAPI = value;
                }
            }
        }

        private RiotApi _riotAPI;

    }
}
