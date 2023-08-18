<?xml version="1.0" encoding="UTF-8"?>

<!--
//
// gir2gapi.xslt
//
// This stylesheet converts gir to gapi format
//
//
//
//
// Author:
//   Andreia Gaita (shana@spoiledcat.net)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
-->

<xsl:stylesheet version="1.0" 
xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
xmlns:exsl="http://exslt.org/common"
xmlns:gir="http://www.gtk.org/introspection/core/1.0"
xmlns:c="http://www.gtk.org/introspection/c/1.0"
xmlns:glib="http://www.gtk.org/introspection/glib/1.0"
exclude-result-prefixes="xsl exsl gir c glib"

>
	<xsl:output method="text"/>
	<xsl:strip-space elements="*" />

	<xsl:param name="type" />
	
	<xsl:key name="version" match="/gir:repository/gir:namespace/*//@version" use="." />

	<xsl:template match="/">
		<xsl:choose>
			<xsl:when test="$type='package'">
				<xsl:value-of select="gir:repository/gir:package/@name" />
			</xsl:when>
			<xsl:when test="$type='libs'">
				<xsl:value-of select="gir:repository/gir:namespace/@shared-library" />
			</xsl:when>
			<xsl:when test="$type='namespace'">
				<xsl:value-of select="gir:repository/gir:namespace/@name" />
			</xsl:when>
			<xsl:when test="$type='version'">
				<xsl:value-of select="gir:repository/gir:namespace/@version" />
			</xsl:when>
			<xsl:when test="$type='include'">
				<xsl:for-each select="gir:repository/c:include">
					<xsl:value-of select="@name" /><xsl:text> </xsl:text>
				</xsl:for-each>
			</xsl:when>
			<xsl:when test="$type='gapi'">
				<xsl:choose>
					<xsl:when test="gir:repository/gir:include[@name='Gdk']/@version='2.0'">2</xsl:when>
					<xsl:otherwise>3</xsl:otherwise>
				</xsl:choose>
			</xsl:when>
			
			<!-- Using 'key' and 'generate-id' function to select version numbers distinctly. -->
			<xsl:when test="$type='libversions'">
				<xsl:for-each select="/gir:repository/gir:namespace/*//@version[generate-id() = generate-id(key('version', .)[1])]">
					<xsl:value-of select="." />
					<xsl:text> </xsl:text>
				</xsl:for-each>
			</xsl:when>
		</xsl:choose>
	</xsl:template>
</xsl:stylesheet>
