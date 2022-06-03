using System.Xml;
using System.Xml.Xsl;

var xslt = new XslCompiledTransform();
xslt.Load("xsl/fdl2proto.xsl", new XsltSettings(), new XmlUrlResolver());
xslt.Transform("GreetingProvider.sila.xml", "GreetingProviderExpected.proto");
