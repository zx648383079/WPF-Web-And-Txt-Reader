﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ZoDream.Reader.Helper.Http;
using ZoDream.Reader.Model;

namespace ZoDream.Reader.Helper
{
    public class HttpHelper
    {
        public static List<ChapterItem> GetBook(ref BookItem item, WebRuleItem rule)
        {
            var html = new Html();
            var chapters = new List<ChapterItem>();
            html.SetUrl(item.Url);
            item.Image = html.GetCover(rule.CoverBegin, rule.CoverEnd);
            item.Author = html.GetAuthor(rule.AuthorBegin, rule.AuthorEnd);
            item.Description = html.GetDescription(rule.DescriptionBegin, rule.DescriptionEnd);
            var ms = html.Match(rule.CatalogBegin, rule.CatalogEnd).Matches(@"<a[^<>]+?href=""?(?<href>[^""<>\s]+)[^<>]*>(?<title>[\s\S]+?)</a>");
            foreach (Match match in ms)
            {
                var url = match.Groups["href"].Value;
                chapters.Add(new ChapterItem(match.Groups["title"].Value, UrlHelper.GetAbsolute(item.Url, url),
                    LocalHelper.GetSafeFile(url)));
            } 
            item.Count = chapters.Count;
            return chapters;
        }
    }
}
