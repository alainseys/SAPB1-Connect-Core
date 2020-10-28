# SAPB1-Connect-Core

<p>This dll provides you acces to sap configuration settings like sql db , sap user ....</p>

<p><b>Example Usage:</b></p>
<p>First you need to add a nuget package (System.ConfigurationManager), then you need to add a app.config.xml file and add your settings (see app.config sample bellow).</p>

<p>Winfom example</p>
<pre>
private void button1_Click(object sender, EvenArgs e)
{
  try
  {
    ServerConnection connection = new ServerConnection();
    connection.GetCompany().Connect();
    if(connection.Connect() == 0)
    {
      MessageBox.show("Connected to :" +connection.GetCompany().CompanyName);
      connection.GetCompany().Disconnect();
    }else
    {
      MessageBox.show("Not connected to sap !");
    }
  }
}
</pre>

<p>app.config example </p>
<configuration>
	<appSettings>
		<add key="server" value="localhost"/>
		<add key="licenseServer" value="localhost:30000"/>
		<add key="dbuser" value="sa"/>
		<add key="dbpass" value="1234"/>
		<add key="companydb" value="SBO"/>
		<add key="user" value="USR"/>
		<add key="pass" value="1234"/>
	</appSettings>
</configuration>


