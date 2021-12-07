using MingweiSamuel.Camille;
using MingweiSamuel.Camille.Enums;
using MingweiSamuel.Camille.MatchV5;
using MingweiSamuel.Camille.SummonerV4;
using RiotAPIFinalProject.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace RiotAPIFinalProject
{
    public partial class MainForm : Form
    {
        private string searchInput => summonerSearchTextBox.Text;

        private string APIKey => riotAPIKeyTextBox.Text;

        private RiotAPIViewModel ViewModel
        {
            get => _viewModel;
            set
            {
                if (_viewModel != value)
                {
                    _viewModel = value;
                    riotAPIViewModelBindingSource.DataSource = _viewModel;
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();
            ViewModel = new RiotAPIViewModel();


        }

        private void riotAPIKeyTextBox_TextChanged(object sender, EventArgs e)
        {
            summonerSearchTextBox.Enabled = !string.IsNullOrWhiteSpace(APIKey);
        }

        private void summonerSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            summonerSearchButton.Enabled = !string.IsNullOrWhiteSpace(searchInput);
        }

        private void summonerSearchButton_Click(object sender, EventArgs e)
        {
            GetSummonerInfo();
        }

        private void GetSummonerInfo()
        {
            ViewModel.RiotInfo = RiotApi.NewInstance(APIKey);     //Current Key: RGAPI-7c172334-8358-458b-b1a8-3fabd65cd958
            ViewModel.Summoner = ViewModel.RiotInfo.SummonerV4.GetBySummonerName(MingweiSamuel.Camille.Enums.Region.NA, searchInput);

            GetMasteryInfo();
            GetMatchInfo();
        }

        private void GetMasteryInfo()
        {
            ViewModel.Masteries = ViewModel.RiotInfo.ChampionMasteryV4.GetAllChampionMasteries(MingweiSamuel.Camille.Enums.Region.NA, ViewModel.Summoner.Id);

            ViewModel.Champions = new BindingList<Champ>();
            foreach (var mastery in ViewModel.Masteries)
            {
                var champion = (Champion)mastery.ChampionId;
                ViewModel.Champions.Add(new Champ(champion.Name(), mastery.ChampionLevel, mastery.ChampionPoints, mastery.ChampionPointsUntilNextLevel, mastery.ChestGranted, mastery.TokensEarned));
            }
        }

        private void GetMatchInfo()
        {
            var matchIDs = ViewModel.RiotInfo.MatchV5.GetMatchIdsByPUUID(MingweiSamuel.Camille.Enums.Region.Americas, ViewModel.Summoner.Puuid);

            ViewModel.CurrentMatchInfo = new BindingList<MatchInfo>();
            foreach (string matchID in matchIDs)
            {

                Match currentMatch = ViewModel.RiotInfo.MatchV5.GetMatch(MingweiSamuel.Camille.Enums.Region.Americas, matchID);
                foreach (KeyValuePair<string, object> entry in currentMatch._AdditionalProperties)
                {
                    if (entry.Key == "info")
                    {
                        _currentMatchInfo = (dynamic)JsonConvert.DeserializeObject<MatchInfo>(entry.Value.ToString());

                    }
                    if (entry.Key == "metadata")
                    {
                        _currentMatchMeta = (dynamic)JsonConvert.DeserializeObject<MatchMeta>(entry.Value.ToString());
                    }
                }

                //_currentMatchParticipants = new List<Summoner>();
                //foreach (var participant in _currentMatchInfo.Participants)
                //{
                //    _currentMatchParticipants.Add((Summoner)_currentMatchInfo.Participant.ParticipantId);
                //}

                //ViewModel.CurrentMatchMeta.Add();
                ViewModel.CurrentMatchInfo.Add(new MatchInfo(_currentMatchInfo.GameName, _currentMatchInfo.GameMode, new MatchMeta(matchID, _currentMatchMeta.Participants)));
            }

        }

        private RiotAPIViewModel _viewModel;
        private dynamic _currentMatchInfo;
        private dynamic _currentMatchMeta;

    }
}