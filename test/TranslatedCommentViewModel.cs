using Amazon.Translate.Model;

namespace test
{
    internal class TranslatedCommentViewModel
    {
        public TranslatedCommentViewModel()
        {
        }

        public object CommentText { get; set; }
        public object SubmitterName { get; set; }
        public object TargetLangauge { get; set; }
        public TranslateTextResponse TranslateResponse { get; set; }
    }
}