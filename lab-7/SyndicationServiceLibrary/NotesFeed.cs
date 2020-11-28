using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Syndication;
using System.ServiceModel.Web;
using System.Text;

namespace SyndicationServiceLibrary
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Feed1" в коде и файле конфигурации.
    public class NotesFeed : INotesFeed
    {
        public SyndicationFeedFormatter GetNotes()
        {
            SyndicationFeed feed = new SyndicationFeed("Subjects & Notes", "Get list of notes by all subjects for this student", null);
            List<SyndicationItem> items = new List<SyndicationItem>();

            Model.Entities entities = new Model.Entities(new Uri("http://localhost:54422/WcfDataService.svc/"));
            foreach (var note in entities.Notes.AsEnumerable())
            {
                var student = (from p in entities.Students
                               where p.studentId == note.studentId
                               select p).First();
                items.Add(new SyndicationItem(
                    title: note.subj + " : " + note.note1,
                    content: student.name.ToString(),
                    itemAlternateLink: new Uri("http://localhost:54422/WcfDataService.svc/Notes(" + note.noteId + ")"),
                    id: student.studentId.ToString(),
                    lastUpdatedTime: DateTime.Now));
            }

            feed.Items = items;

            string query = WebOperationContext.Current.IncomingRequest.UriTemplateMatch.QueryParameters["format"];
            SyndicationFeedFormatter formatter = null;
            if (query == "atom")
            {
                formatter = new Atom10FeedFormatter(feed);
            }
            else
            {
                formatter = new Rss20FeedFormatter(feed);
            }

            return formatter;
        }
    }
}
