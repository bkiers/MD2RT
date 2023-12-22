﻿using HtmlAgilityPack;

namespace MD2RT.Models.Nodes;

public class TableRow : Node
{
  public TableRow() : base("tableRow")
  {
  }

  public override HtmlNode RenderHtmlNode()
  {
    return HtmlNode.CreateNode("<tr></tr>");
  }
}
