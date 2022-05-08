namespace OiuTools.Api.Application.BeMo
{
    public class PageDto
    {
        public int PageIndex { get; set; } = 1;

        public int PageSize { get; set; } = 20;

        public int RecordCount { get; set; }

    }
}