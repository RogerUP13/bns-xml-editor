﻿using System.Xml.Linq;

namespace XmlMigrater
{
	public class InvalidTranslateItem : TranslatedItem
	{
		public string NewText { get; set; }

		public InvalidTranslateItem(int autoId, string alias, string original, string replacement, string newText)
			: base(autoId, alias, original, replacement)
		{
			NewText = newText;
		}

		public override XElement GetXElement()
		{
			return new XElement("TEXT",
				new XElement("autoId", AutoId),
				new XElement("alias", Alias),
				new XElement("original", Text),
				new XElement("replacement", Translate),
				new XElement("newText", NewText)
				);
		}
	}
}