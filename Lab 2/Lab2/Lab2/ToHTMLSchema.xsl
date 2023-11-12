<?xml version ="1.0" encoding ="utf-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
	<xsl:output method='html'/>
	<xsl:template match="facultySoftwareDatabase">
		<HTML>
			<BODY>
				<p><H2> Програмне забезпечення на мережі факультету </H2></p>
				<TABLE BORDER="2">
					<TR>
						<TH>Назва</TH>
						<TH>Анотація</TH>
						<TH>Вид</TH>
						<TH>Версія</TH>
						<TH>Автор</TH>
						<TH>Умови використання</TH>
						<TH>Місце запису дистрибутиву</TH>
					</TR>
					<xsl:for-each select="//Software">
						<TR>
							<TD>
								<xsl:value-of select="@Name"/>
							</TD>
							<TD>
								<xsl:value-of select="@Annotation"/>
							</TD>
							<TD>
								<xsl:value-of select="@Type"/>
							</TD>
							<TD>
								<xsl:value-of select="@Version"/>
							</TD>
							<TD>
								<xsl:value-of select="@Author"/>
							</TD>
							<TD>
								<xsl:value-of select="@TermsOfUsage"/>
							</TD>
							<TD>
								<xsl:value-of select="@DistributiveLocation"/>
							</TD>
						</TR>
					</xsl:for-each>
				</TABLE>
			</BODY>		
		</HTML>	
	</xsl:template>
</xsl:stylesheet>
