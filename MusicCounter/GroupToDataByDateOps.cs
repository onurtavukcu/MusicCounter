using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCounter
{
    public class GroupToDataByDateOps
    {
        public void GroupingData(List<PlayerModel> playerModels)
        {
            var result = playerModels
                .GroupBy(model => model.PLAY_TS.Date)
                .Select(grouping => new
                {
                    Date = grouping.Key,
                    Data = grouping
                        .GroupBy(dateGroupingModel => dateGroupingModel.CLIENT_ID)
                        .Select(dateGroupingModelGrouping => new
                        {
                            ClientId = dateGroupingModelGrouping.Key,
                            DistingSongCount = dateGroupingModelGrouping.Select(record => record.SONG_ID).Distinct().Count()
                        })
                        .GroupBy(x => x.DistingSongCount)
                        .Select(x => new
                        {
                            DistinctPlayCount = x.Key,
                            ClientCount = x.Count()
                        })
                });

            var result346 = result.Select(song => song.Data.Where(count => count.DistinctPlayCount == 346));

            var maxPlayedSound = result.Select(song => song.Data.Max(max => max.DistinctPlayCount);
        }
    }
}