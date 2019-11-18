using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwitterLogic
{
    public class TweetManager
    {
        protected TwitterDB _db;

        public TweetManager(TwitterDB db)
        {
            _db = db;
        }

        public GeoTwitterDataEntry Get(Guid guid)
        {
            return _db.TweetsList.FirstOrDefault(i => i.TweetKeyGuid == guid);
        }
        public List<GeoTwitterDataEntry> GetAll()
        {
            return _db.TweetsList
                .OrderByDescending(i => i.TweetCreationDateTimeUtc)
                .ToList();
        }

        public void Delete(Guid guid)
        {
            var tweet = _db.TweetsList.FirstOrDefault(i => i.TweetKeyGuid == guid);
            _db.Remove(tweet);
            _db.SaveChanges();

        }

        public GeoTwitterDataEntry Create (GeoTwitterDataEntry tweet)
        {
            _db.Add(tweet);
            _db.SaveChanges();
            return tweet;
        }

        public GeoTwitterDataEntry Update (GeoTwitterDataEntry tweet)
        {
            var currenttweet = _db.TweetsList.FirstOrDefault(i => i.TweetKeyGuid == tweet.TweetKeyGuid);
            currenttweet.TweetText = tweet.TweetText;

            return (currenttweet);
        }

    }
}
