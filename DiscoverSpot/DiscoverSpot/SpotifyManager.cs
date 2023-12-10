﻿using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscoverSpot
{
    public class spotifyManager
    {
        private static EmbedIOAuthServer _server;
        private static SpotifyClient _spotify;
        private static bool _spotifyInitialized = false;
        private string _trackName;
        private SpotifyAPI.Web.PrivateUser _user;
        private RecommendationsRequest _recommendationData;

        private bool _considerGenre = false;
        private bool _considerArtist = false;
        private string _dancability = "0.8";

        public spotifyManager()
        {

            // initial values for everything... even if empty, just in case
            _recommendationData = new RecommendationsRequest()
            {
                Limit = 30, // Adjust the limit as needed
                Target =
                {
                    { "danceability", "0.8" } // Adjust the target danceability value as needed
                },
                SeedGenres =
                {
                    "acoustic"
                },
                SeedTracks =
                {
                    "7EZC6E7UjZe63f1jRmkWxt" // The Cranberries "Zombie" because I needed a default value and happened to be listening to it
                }
            };
        }

        public bool IsInitialized()
        {
            return _spotifyInitialized;
        }

        public string getUserName()
        {
            return _user.DisplayName;
        }

        public string getTrackName()
        {
            return _trackName;
        }

        // data used later when generating tracks, set by configure form
        public void setConfigurationData(bool considerArtist, bool considerGenre, string dancability)
        {
            _considerArtist = considerArtist;
            _considerGenre = considerGenre;
            _dancability = dancability;
        }

        public bool IsConsideringArtist()
        {
            return _considerArtist;
        }

        public bool IsConsideringGenere()
        {
            return _considerGenre;
        }

        public string getDancability()
        {
            return _dancability;
        }

        public void setReccomendationSeeds(List<string> tracks = null, List<string> generes = null, List<string> artists = null)
        {
            string genereString = "", trackString = "", artistString = "";

            if(tracks == null)
            {
                MessageBox.Show("Seed values set without Tracks", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            trackString = tracks.Aggregate((a, x) => a + "," + x);
            if (generes != null && _considerGenre) genereString = generes.Aggregate((a, x) => a + "," + x);
            if(artists != null && _considerArtist) artistString = artists.Aggregate((a, x) => a + "," + x);

            _recommendationData = new RecommendationsRequest()
            {
                Limit = 30,
                Target = { { "danceability", _dancability } },
                SeedGenres = {genereString},
                SeedArtists = {artistString},
                SeedTracks = {trackString}
            };
        }

        public async Task InitializeSpotify()
        {
            _server = new EmbedIOAuthServer(new Uri("http://localhost:5543/callback"), 5543);
            await _server.Start();

            _server.AuthorizationCodeReceived += OnAuthorizationCodeReceived;
            _server.ErrorReceived += OnErrorReceived;

            //client ID goes in second field of LoginRequest
            var request = new LoginRequest(_server.BaseUri, "07d2f610371745aba056026392538495", LoginRequest.ResponseType.Code)
            {
                Scope = new List<string> {
                Scopes.UserTopRead,
                Scopes.PlaylistModifyPrivate,
                Scopes.PlaylistModifyPublic,
                Scopes.UserReadEmail
                }
            };

            BrowserUtil.Open(request.ToUri());

            // Check every 100 milliseconds if spotify has successfully initizaled before making api calls
            while (!_spotifyInitialized)
            {
                await Task.Delay(100);
            }

            // Get user profile
            _user = await _spotify.UserProfile.Current();
        }

        public async Task OnAuthorizationCodeReceived(object sender, AuthorizationCodeResponse response)
        {
            await _server.Stop();

            //client ID goes in first field of AuthorizationCodeTokenRequest
            //client secret goes in second field of AuthorizationCodeTokenRequest
            var config = SpotifyClientConfig.CreateDefault();
            var tokenResponse = await new OAuthClient(config).RequestToken(
                new AuthorizationCodeTokenRequest(
                    "07d2f610371745aba056026392538495", "469e5c1e0ad64a42a77fe116099330f3", response.Code, new Uri("http://localhost:5543/callback")
                )
            );
            // save token in _spotify
            _spotify = new SpotifyClient(tokenResponse.AccessToken);
            _spotifyInitialized = true;
        }

        public async Task OnErrorReceived(object sender, string error, string state)
        {
            await _server.Stop();
        }
        public async Task CreatePlaylist()
        {
            var user = await _spotify.UserProfile.Current();

            // Request song recommendations based on the seeds
            var recommendations = await _spotify.Browse.GetRecommendations(_recommendationData);

            System.Diagnostics.Debug.WriteLine(string.Join(",\n", recommendations.Tracks.Select(track => track.Name).ToList()));

            // Create SpotDiscover playlist
            var playlistRequest = new PlaylistCreateRequest("SpotDiscover")
            {
                Description = "Daily Discovery Playlist",
                Public = false
            };

            //var createdPlaylist = await _spotify.Playlists.Create(user.Id, playlistRequest);

            //// Add recommended tracks to the playlist
            //var trackUris = recommendations.Tracks.Select(recommendedTrack => recommendedTrack.Uri).ToList();
            //await _spotify.Playlists.AddItems(createdPlaylist.Id, new PlaylistAddItemsRequest(trackUris));
        }


        public async Task GetTrack()
        {
            // displays track "diskhat1"
            var track = await _spotify.Tracks.Get("1s6ux0lNiTziSrd7iUAADH");

            _trackName = track.Name;
        }
    }
}