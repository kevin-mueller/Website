using System;

namespace Website.Data.Models
{
    public class Repository
    {
        public long Id { get; set; }
        
        public string NodeId { get; set; }
        
        public string Name { get; set; }

        public string FullName { get; set; }

        public bool Private { get; set; }

        public Owner Owner { get; set; }

        public Uri HtmlUrl { get; set; }

        public string Description { get; set; }

        public bool Fork { get; set; }

        public Uri Url { get; set; }

        public Uri ForksUrl { get; set; }

        public string KeysUrl { get; set; }

        public string CollaboratorsUrl { get; set; }

        public Uri TeamsUrl { get; set; }

        public Uri HooksUrl { get; set; }

        public string IssueEventsUrl { get; set; }

        public Uri EventsUrl { get; set; }

        public string AssigneesUrl { get; set; }

        public string BranchesUrl { get; set; }

        public Uri TagsUrl { get; set; }

        public string BlobsUrl { get; set; }


        public string GitTagsUrl { get; set; }


        public string GitRefsUrl { get; set; }


        public string TreesUrl { get; set; }


        public string StatusesUrl { get; set; }


        public Uri LanguagesUrl { get; set; }


        public Uri StargazersUrl { get; set; }


        public Uri ContributorsUrl { get; set; }


        public Uri SubscribersUrl { get; set; }


        public Uri SubscriptionUrl { get; set; }


        public string CommitsUrl { get; set; }


        public string GitCommitsUrl { get; set; }


        public string CommentsUrl { get; set; }


        public string IssueCommentUrl { get; set; }


        public string ContentsUrl { get; set; }


        public string CompareUrl { get; set; }


        public Uri MergesUrl { get; set; }


        public string ArchiveUrl { get; set; }


        public Uri DownloadsUrl { get; set; }


        public string IssuesUrl { get; set; }


        public string PullsUrl { get; set; }


        public string MilestonesUrl { get; set; }


        public string NotificationsUrl { get; set; }


        public string LabelsUrl { get; set; }


        public string ReleasesUrl { get; set; }


        public Uri DeploymentsUrl { get; set; }


        public DateTimeOffset CreatedAt { get; set; }


        public DateTimeOffset UpdatedAt { get; set; }


        public DateTimeOffset PushedAt { get; set; }


        public string GitUrl { get; set; }


        public string SshUrl { get; set; }


        public Uri CloneUrl { get; set; }


        public Uri SvnUrl { get; set; }


        public string Homepage { get; set; }


        public long Size { get; set; }


        public long StargazersCount { get; set; }


        public long WatchersCount { get; set; }


        public string Language { get; set; }


        public bool HasIssues { get; set; }


        public bool HasProjects { get; set; }


        public bool HasDownloads { get; set; }


        public bool HasWiki { get; set; }


        public bool HasPages { get; set; }


        public long ForksCount { get; set; }


        public object MirrorUrl { get; set; }


        public bool Archived { get; set; }


        public bool Disabled { get; set; }


        public long OpenIssuesCount { get; set; }


        public object License { get; set; }


        public long Forks { get; set; }


        public long OpenIssues { get; set; }


        public long Watchers { get; set; }


        public string DefaultBranch { get; set; }
    }

    public partial class Owner
    {
        public string Login { get; set; }


        public long Id { get; set; }


        public string NodeId { get; set; }


        public Uri AvatarUrl { get; set; }


        public string GravatarId { get; set; }


        public Uri Url { get; set; }


        public Uri HtmlUrl { get; set; }


        public Uri FollowersUrl { get; set; }


        public string FollowingUrl { get; set; }


        public string GistsUrl { get; set; }


        public string StarredUrl { get; set; }


        public Uri SubscriptionsUrl { get; set; }


        public Uri OrganizationsUrl { get; set; }


        public Uri ReposUrl { get; set; }


        public string EventsUrl { get; set; }


        public Uri ReceivedEventsUrl { get; set; }


        public string Type { get; set; }

        public bool SiteAdmin { get; set; }
    }
}