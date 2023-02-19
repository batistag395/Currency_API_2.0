

<html>

    <head><link rel="alternate" type="text/xml" href="/calculador/calcprecoprazo.asmx?disco" />

    <style type="text/css">
    
		BODY { color: #000000; background-color: white; font-family: Verdana; margin-left: 0px; margin-top: 0px; }
		#content { margin-left: 30px; font-size: .70em; padding-bottom: 2em; }
		A:link { color: #336699; font-weight: bold; text-decoration: underline; }
		A:visited { color: #6699cc; font-weight: bold; text-decoration: underline; }
		A:active { color: #336699; font-weight: bold; text-decoration: underline; }
		A:hover { color: cc3300; font-weight: bold; text-decoration: underline; }
		P { color: #000000; margin-top: 0px; margin-bottom: 12px; font-family: Verdana; }
		pre { background-color: #e5e5cc; padding: 5px; font-family: Courier New; font-size: x-small; margin-top: -5px; border: 1px #f0f0e0 solid; }
		td { color: #000000; font-family: Verdana; font-size: .7em; }
		h2 { font-size: 1.5em; font-weight: bold; margin-top: 25px; margin-bottom: 10px; border-top: 1px solid #003366; margin-left: -15px; color: #003366; }
		h3 { font-size: 1.1em; color: #000000; margin-left: -15px; margin-top: 10px; margin-bottom: 10px; }
		ul { margin-top: 10px; margin-left: 20px; }
		ol { margin-top: 10px; margin-left: 20px; }
		li { margin-top: 10px; color: #000000; }
		font.value { color: darkblue; font: bold; }
		font.key { color: darkgreen; font: bold; }
		font.error { color: darkred; font: bold; }
		.heading1 { color: #ffffff; font-family: Tahoma; font-size: 26px; font-weight: normal; background-color: #003366; margin-top: 0px; margin-bottom: 0px; margin-left: -30px; padding-top: 10px; padding-bottom: 3px; padding-left: 15px; width: 105%; }
		.button { background-color: #dcdcdc; font-family: Verdana; font-size: 1em; border-top: #cccccc 1px solid; border-bottom: #666666 1px solid; border-left: #cccccc 1px solid; border-right: #666666 1px solid; }
		.frmheader { color: #000000; background: #dcdcdc; font-family: Verdana; font-size: .7em; font-weight: normal; border-bottom: 1px solid #dcdcdc; padding-top: 2px; padding-bottom: 2px; }
		.frmtext { font-family: Verdana; font-size: .7em; margin-top: 8px; margin-bottom: 0px; margin-left: 32px; }
		.frmInput { font-family: Verdana; font-size: 1em; }
		.intro { margin-left: -15px; }
           
    </style>

    <title>
	CalcPrecoPrazoWS Web Service
</title></head>

  <body>

    <div id="content">

      <p class="heading1">CalcPrecoPrazoWS</p><br>

      

      

      <span>
          <p class="intro">Click <a href="calcprecoprazo.asmx">here</a> for a complete list of operations.</p>
          <h2>CalcPrecoPrazo</h2>
          <p class="intro">Calcula o pre�o e o prazo com a data atual</p>

          <h3>Test</h3>
          
          To test the operation using the HTTP POST protocol, click the 'Invoke' button.



                      <form target="_blank" action='http://ws.correios.com.br:8082/calculador/calcprecoprazo.asmx/CalcPrecoPrazo' method="POST">                      
                        
                          <table cellspacing="0" cellpadding="4" frame="box" bordercolor="#dcdcdc" rules="none" style="border-collapse: collapse;">
                          <tr>
	<td class="frmHeader" background="#dcdcdc" style="border-right: 2px solid white;">Parameter</td>
	<td class="frmHeader" background="#dcdcdc">Value</td>
</tr>

                        
                          <tr>
                            <td class="frmText" style="color: #000000; font-weight: normal;">nCdEmpresa:</td>
                            <td><input class="frmInput" type="text" size="50" name="nCdEmpresa"></td>
                          </tr>
                        
                          <tr>
                            <td class="frmText" style="color: #000000; font-weight: normal;">sDsSenha:</td>
                            <td><input class="frmInput" type="text" size="50" name="sDsSenha"></td>
                          </tr>
                        
                          <tr>
                            <td class="frmText" style="color: #000000; font-weight: normal;">nCdServico:</td>
                            <td><input class="frmInput" type="text" size="50" name="nCdServico"></td>
                          </tr>
                        
                          <tr>
                            <td class="frmText" style="color: #000000; font-weight: normal;">sCepOrigem:</td>
                            <td><input class="frmInput" type="text" size="50" name="sCepOrigem"></td>
                          </tr>
                        
                          <tr>
                            <td class="frmText" style="color: #000000; font-weight: normal;">sCepDestino:</td>
                            <td><input class="frmInput" type="text" size="50" name="sCepDestino"></td>
                          </tr>
                        
                          <tr>
                            <td class="frmText" style="color: #000000; font-weight: normal;">nVlPeso:</td>
                            <td><input class="frmInput" type="text" size="50" name="nVlPeso"></td>
                          </tr>
                        
                          <tr>
                            <td class="frmText" style="color: #000000; font-weight: normal;">nCdFormato:</td>
                            <td><input class="frmInput" type="text" size="50" name="nCdFormato"></td>
                          </tr>
                        
                          <tr>
                            <td class="frmText" style="color: #000000; font-weight: normal;">nVlComprimento:</td>
                            <td><input class="frmInput" type="text" size="50" name="nVlComprimento"></td>
                          </tr>
                        
                          <tr>
                            <td class="frmText" style="color: #000000; font-weight: normal;">nVlAltura:</td>
                            <td><input class="frmInput" type="text" size="50" name="nVlAltura"></td>
                          </tr>
                        
                          <tr>
                            <td class="frmText" style="color: #000000; font-weight: normal;">nVlLargura:</td>
                            <td><input class="frmInput" type="text" size="50" name="nVlLargura"></td>
                          </tr>
                        
                          <tr>
                            <td class="frmText" style="color: #000000; font-weight: normal;">nVlDiametro:</td>
                            <td><input class="frmInput" type="text" size="50" name="nVlDiametro"></td>
                          </tr>
                        
                          <tr>
                            <td class="frmText" style="color: #000000; font-weight: normal;">sCdMaoPropria:</td>
                            <td><input class="frmInput" type="text" size="50" name="sCdMaoPropria"></td>
                          </tr>
                        
                          <tr>
                            <td class="frmText" style="color: #000000; font-weight: normal;">nVlValorDeclarado:</td>
                            <td><input class="frmInput" type="text" size="50" name="nVlValorDeclarado"></td>
                          </tr>
                        
                          <tr>
                            <td class="frmText" style="color: #000000; font-weight: normal;">sCdAvisoRecebimento:</td>
                            <td><input class="frmInput" type="text" size="50" name="sCdAvisoRecebimento"></td>
                          </tr>
                        
                        <tr>
                          <td></td>
                          <td align="right"> <input type="submit" value="Invoke" class="button"></td>
                        </tr>
                        </table>
                      

                    </form>
                  <span>
              <h3>SOAP 1.1</h3>
              <p>The following is a sample SOAP 1.1 request and response.  The <font class=value>placeholders</font> shown need to be replaced with actual values.</p>

              <pre>POST /calculador/calcprecoprazo.asmx HTTP/1.1
Host: ws.correios.com.br
Content-Type: text/xml; charset=utf-8
Content-Length: <font class=value>length</font>
SOAPAction: "http://tempuri.org/CalcPrecoPrazo"

&lt;?xml version="1.0" encoding="utf-8"?&gt;
&lt;soap:Envelope xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:soap="http://schemas.xmlsoap.org/soap/envelope/"&gt;
  &lt;soap:Body&gt;
    &lt;CalcPrecoPrazo xmlns="http://tempuri.org/"&gt;
      &lt;nCdEmpresa&gt;<font class=value>string</font>&lt;/nCdEmpresa&gt;
      &lt;sDsSenha&gt;<font class=value>string</font>&lt;/sDsSenha&gt;
      &lt;nCdServico&gt;<font class=value>string</font>&lt;/nCdServico&gt;
      &lt;sCepOrigem&gt;<font class=value>string</font>&lt;/sCepOrigem&gt;
      &lt;sCepDestino&gt;<font class=value>string</font>&lt;/sCepDestino&gt;
      &lt;nVlPeso&gt;<font class=value>string</font>&lt;/nVlPeso&gt;
      &lt;nCdFormato&gt;<font class=value>int</font>&lt;/nCdFormato&gt;
      &lt;nVlComprimento&gt;<font class=value>decimal</font>&lt;/nVlComprimento&gt;
      &lt;nVlAltura&gt;<font class=value>decimal</font>&lt;/nVlAltura&gt;
      &lt;nVlLargura&gt;<font class=value>decimal</font>&lt;/nVlLargura&gt;
      &lt;nVlDiametro&gt;<font class=value>decimal</font>&lt;/nVlDiametro&gt;
      &lt;sCdMaoPropria&gt;<font class=value>string</font>&lt;/sCdMaoPropria&gt;
      &lt;nVlValorDeclarado&gt;<font class=value>decimal</font>&lt;/nVlValorDeclarado&gt;
      &lt;sCdAvisoRecebimento&gt;<font class=value>string</font>&lt;/sCdAvisoRecebimento&gt;
    &lt;/CalcPrecoPrazo&gt;
  &lt;/soap:Body&gt;
&lt;/soap:Envelope&gt;</pre>

              <pre>HTTP/1.1 200 OK
Content-Type: text/xml; charset=utf-8
Content-Length: <font class=value>length</font>

&lt;?xml version="1.0" encoding="utf-8"?&gt;
&lt;soap:Envelope xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:soap="http://schemas.xmlsoap.org/soap/envelope/"&gt;
  &lt;soap:Body&gt;
    &lt;CalcPrecoPrazoResponse xmlns="http://tempuri.org/"&gt;
      &lt;CalcPrecoPrazoResult&gt;
        &lt;Servicos&gt;
          &lt;cServico&gt;
            &lt;Codigo&gt;<font class=value>int</font>&lt;/Codigo&gt;
            &lt;Valor&gt;<font class=value>string</font>&lt;/Valor&gt;
            &lt;PrazoEntrega&gt;<font class=value>string</font>&lt;/PrazoEntrega&gt;
            &lt;ValorMaoPropria&gt;<font class=value>string</font>&lt;/ValorMaoPropria&gt;
            &lt;ValorAvisoRecebimento&gt;<font class=value>string</font>&lt;/ValorAvisoRecebimento&gt;
            &lt;ValorValorDeclarado&gt;<font class=value>string</font>&lt;/ValorValorDeclarado&gt;
            &lt;EntregaDomiciliar&gt;<font class=value>string</font>&lt;/EntregaDomiciliar&gt;
            &lt;EntregaSabado&gt;<font class=value>string</font>&lt;/EntregaSabado&gt;
            &lt;Erro&gt;<font class=value>string</font>&lt;/Erro&gt;
            &lt;MsgErro&gt;<font class=value>string</font>&lt;/MsgErro&gt;
            &lt;ValorSemAdicionais&gt;<font class=value>string</font>&lt;/ValorSemAdicionais&gt;
            &lt;obsFim&gt;<font class=value>string</font>&lt;/obsFim&gt;
            &lt;DataMaxEntrega&gt;<font class=value>string</font>&lt;/DataMaxEntrega&gt;
            &lt;HoraMaxEntrega&gt;<font class=value>string</font>&lt;/HoraMaxEntrega&gt;
          &lt;/cServico&gt;
          &lt;cServico&gt;
            &lt;Codigo&gt;<font class=value>int</font>&lt;/Codigo&gt;
            &lt;Valor&gt;<font class=value>string</font>&lt;/Valor&gt;
            &lt;PrazoEntrega&gt;<font class=value>string</font>&lt;/PrazoEntrega&gt;
            &lt;ValorMaoPropria&gt;<font class=value>string</font>&lt;/ValorMaoPropria&gt;
            &lt;ValorAvisoRecebimento&gt;<font class=value>string</font>&lt;/ValorAvisoRecebimento&gt;
            &lt;ValorValorDeclarado&gt;<font class=value>string</font>&lt;/ValorValorDeclarado&gt;
            &lt;EntregaDomiciliar&gt;<font class=value>string</font>&lt;/EntregaDomiciliar&gt;
            &lt;EntregaSabado&gt;<font class=value>string</font>&lt;/EntregaSabado&gt;
            &lt;Erro&gt;<font class=value>string</font>&lt;/Erro&gt;
            &lt;MsgErro&gt;<font class=value>string</font>&lt;/MsgErro&gt;
            &lt;ValorSemAdicionais&gt;<font class=value>string</font>&lt;/ValorSemAdicionais&gt;
            &lt;obsFim&gt;<font class=value>string</font>&lt;/obsFim&gt;
            &lt;DataMaxEntrega&gt;<font class=value>string</font>&lt;/DataMaxEntrega&gt;
            &lt;HoraMaxEntrega&gt;<font class=value>string</font>&lt;/HoraMaxEntrega&gt;
          &lt;/cServico&gt;
        &lt;/Servicos&gt;
      &lt;/CalcPrecoPrazoResult&gt;
    &lt;/CalcPrecoPrazoResponse&gt;
  &lt;/soap:Body&gt;
&lt;/soap:Envelope&gt;</pre>
          </span>

          <span>
              <h3>SOAP 1.2</h3>
              <p>The following is a sample SOAP 1.2 request and response.  The <font class=value>placeholders</font> shown need to be replaced with actual values.</p>

              <pre>POST /calculador/calcprecoprazo.asmx HTTP/1.1
Host: ws.correios.com.br
Content-Type: application/soap+xml; charset=utf-8
Content-Length: <font class=value>length</font>

&lt;?xml version="1.0" encoding="utf-8"?&gt;
&lt;soap12:Envelope xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:soap12="http://www.w3.org/2003/05/soap-envelope"&gt;
  &lt;soap12:Body&gt;
    &lt;CalcPrecoPrazo xmlns="http://tempuri.org/"&gt;
      &lt;nCdEmpresa&gt;<font class=value>string</font>&lt;/nCdEmpresa&gt;
      &lt;sDsSenha&gt;<font class=value>string</font>&lt;/sDsSenha&gt;
      &lt;nCdServico&gt;<font class=value>string</font>&lt;/nCdServico&gt;
      &lt;sCepOrigem&gt;<font class=value>string</font>&lt;/sCepOrigem&gt;
      &lt;sCepDestino&gt;<font class=value>string</font>&lt;/sCepDestino&gt;
      &lt;nVlPeso&gt;<font class=value>string</font>&lt;/nVlPeso&gt;
      &lt;nCdFormato&gt;<font class=value>int</font>&lt;/nCdFormato&gt;
      &lt;nVlComprimento&gt;<font class=value>decimal</font>&lt;/nVlComprimento&gt;
      &lt;nVlAltura&gt;<font class=value>decimal</font>&lt;/nVlAltura&gt;
      &lt;nVlLargura&gt;<font class=value>decimal</font>&lt;/nVlLargura&gt;
      &lt;nVlDiametro&gt;<font class=value>decimal</font>&lt;/nVlDiametro&gt;
      &lt;sCdMaoPropria&gt;<font class=value>string</font>&lt;/sCdMaoPropria&gt;
      &lt;nVlValorDeclarado&gt;<font class=value>decimal</font>&lt;/nVlValorDeclarado&gt;
      &lt;sCdAvisoRecebimento&gt;<font class=value>string</font>&lt;/sCdAvisoRecebimento&gt;
    &lt;/CalcPrecoPrazo&gt;
  &lt;/soap12:Body&gt;
&lt;/soap12:Envelope&gt;</pre>

              <pre>HTTP/1.1 200 OK
Content-Type: application/soap+xml; charset=utf-8
Content-Length: <font class=value>length</font>

&lt;?xml version="1.0" encoding="utf-8"?&gt;
&lt;soap12:Envelope xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:soap12="http://www.w3.org/2003/05/soap-envelope"&gt;
  &lt;soap12:Body&gt;
    &lt;CalcPrecoPrazoResponse xmlns="http://tempuri.org/"&gt;
      &lt;CalcPrecoPrazoResult&gt;
        &lt;Servicos&gt;
          &lt;cServico&gt;
            &lt;Codigo&gt;<font class=value>int</font>&lt;/Codigo&gt;
            &lt;Valor&gt;<font class=value>string</font>&lt;/Valor&gt;
            &lt;PrazoEntrega&gt;<font class=value>string</font>&lt;/PrazoEntrega&gt;
            &lt;ValorMaoPropria&gt;<font class=value>string</font>&lt;/ValorMaoPropria&gt;
            &lt;ValorAvisoRecebimento&gt;<font class=value>string</font>&lt;/ValorAvisoRecebimento&gt;
            &lt;ValorValorDeclarado&gt;<font class=value>string</font>&lt;/ValorValorDeclarado&gt;
            &lt;EntregaDomiciliar&gt;<font class=value>string</font>&lt;/EntregaDomiciliar&gt;
            &lt;EntregaSabado&gt;<font class=value>string</font>&lt;/EntregaSabado&gt;
            &lt;Erro&gt;<font class=value>string</font>&lt;/Erro&gt;
            &lt;MsgErro&gt;<font class=value>string</font>&lt;/MsgErro&gt;
            &lt;ValorSemAdicionais&gt;<font class=value>string</font>&lt;/ValorSemAdicionais&gt;
            &lt;obsFim&gt;<font class=value>string</font>&lt;/obsFim&gt;
            &lt;DataMaxEntrega&gt;<font class=value>string</font>&lt;/DataMaxEntrega&gt;
            &lt;HoraMaxEntrega&gt;<font class=value>string</font>&lt;/HoraMaxEntrega&gt;
          &lt;/cServico&gt;
          &lt;cServico&gt;
            &lt;Codigo&gt;<font class=value>int</font>&lt;/Codigo&gt;
            &lt;Valor&gt;<font class=value>string</font>&lt;/Valor&gt;
            &lt;PrazoEntrega&gt;<font class=value>string</font>&lt;/PrazoEntrega&gt;
            &lt;ValorMaoPropria&gt;<font class=value>string</font>&lt;/ValorMaoPropria&gt;
            &lt;ValorAvisoRecebimento&gt;<font class=value>string</font>&lt;/ValorAvisoRecebimento&gt;
            &lt;ValorValorDeclarado&gt;<font class=value>string</font>&lt;/ValorValorDeclarado&gt;
            &lt;EntregaDomiciliar&gt;<font class=value>string</font>&lt;/EntregaDomiciliar&gt;
            &lt;EntregaSabado&gt;<font class=value>string</font>&lt;/EntregaSabado&gt;
            &lt;Erro&gt;<font class=value>string</font>&lt;/Erro&gt;
            &lt;MsgErro&gt;<font class=value>string</font>&lt;/MsgErro&gt;
            &lt;ValorSemAdicionais&gt;<font class=value>string</font>&lt;/ValorSemAdicionais&gt;
            &lt;obsFim&gt;<font class=value>string</font>&lt;/obsFim&gt;
            &lt;DataMaxEntrega&gt;<font class=value>string</font>&lt;/DataMaxEntrega&gt;
            &lt;HoraMaxEntrega&gt;<font class=value>string</font>&lt;/HoraMaxEntrega&gt;
          &lt;/cServico&gt;
        &lt;/Servicos&gt;
      &lt;/CalcPrecoPrazoResult&gt;
    &lt;/CalcPrecoPrazoResponse&gt;
  &lt;/soap12:Body&gt;
&lt;/soap12:Envelope&gt;</pre>
          </span>

          <span>
              <h3>HTTP GET</h3>
              <p>The following is a sample HTTP GET request and response.  The <font class=value>placeholders</font> shown need to be replaced with actual values.</p>

              <pre>GET /calculador/calcprecoprazo.asmx/CalcPrecoPrazo?<font class=key>nCdEmpresa</font>=<font class=value>string</font>&amp;<font class=key>sDsSenha</font>=<font class=value>string</font>&amp;<font class=key>nCdServico</font>=<font class=value>string</font>&amp;<font class=key>sCepOrigem</font>=<font class=value>string</font>&amp;<font class=key>sCepDestino</font>=<font class=value>string</font>&amp;<font class=key>nVlPeso</font>=<font class=value>string</font>&amp;<font class=key>nCdFormato</font>=<font class=value>string</font>&amp;<font class=key>nVlComprimento</font>=<font class=value>string</font>&amp;<font class=key>nVlAltura</font>=<font class=value>string</font>&amp;<font class=key>nVlLargura</font>=<font class=value>string</font>&amp;<font class=key>nVlDiametro</font>=<font class=value>string</font>&amp;<font class=key>sCdMaoPropria</font>=<font class=value>string</font>&amp;<font class=key>nVlValorDeclarado</font>=<font class=value>string</font>&amp;<font class=key>sCdAvisoRecebimento</font>=<font class=value>string</font> HTTP/1.1
Host: ws.correios.com.br
</pre>

              <pre>HTTP/1.1 200 OK
Content-Type: text/xml; charset=utf-8
Content-Length: <font class=value>length</font>

&lt;?xml version="1.0" encoding="utf-8"?&gt;
&lt;cResultado xmlns="http://tempuri.org/"&gt;
  &lt;Servicos&gt;
    &lt;cServico&gt;
      &lt;Codigo&gt;<font class=value>int</font>&lt;/Codigo&gt;
      &lt;Valor&gt;<font class=value>string</font>&lt;/Valor&gt;
      &lt;PrazoEntrega&gt;<font class=value>string</font>&lt;/PrazoEntrega&gt;
      &lt;ValorMaoPropria&gt;<font class=value>string</font>&lt;/ValorMaoPropria&gt;
      &lt;ValorAvisoRecebimento&gt;<font class=value>string</font>&lt;/ValorAvisoRecebimento&gt;
      &lt;ValorValorDeclarado&gt;<font class=value>string</font>&lt;/ValorValorDeclarado&gt;
      &lt;EntregaDomiciliar&gt;<font class=value>string</font>&lt;/EntregaDomiciliar&gt;
      &lt;EntregaSabado&gt;<font class=value>string</font>&lt;/EntregaSabado&gt;
      &lt;Erro&gt;<font class=value>string</font>&lt;/Erro&gt;
      &lt;MsgErro&gt;<font class=value>string</font>&lt;/MsgErro&gt;
      &lt;ValorSemAdicionais&gt;<font class=value>string</font>&lt;/ValorSemAdicionais&gt;
      &lt;obsFim&gt;<font class=value>string</font>&lt;/obsFim&gt;
      &lt;DataMaxEntrega&gt;<font class=value>string</font>&lt;/DataMaxEntrega&gt;
      &lt;HoraMaxEntrega&gt;<font class=value>string</font>&lt;/HoraMaxEntrega&gt;
    &lt;/cServico&gt;
    &lt;cServico&gt;
      &lt;Codigo&gt;<font class=value>int</font>&lt;/Codigo&gt;
      &lt;Valor&gt;<font class=value>string</font>&lt;/Valor&gt;
      &lt;PrazoEntrega&gt;<font class=value>string</font>&lt;/PrazoEntrega&gt;
      &lt;ValorMaoPropria&gt;<font class=value>string</font>&lt;/ValorMaoPropria&gt;
      &lt;ValorAvisoRecebimento&gt;<font class=value>string</font>&lt;/ValorAvisoRecebimento&gt;
      &lt;ValorValorDeclarado&gt;<font class=value>string</font>&lt;/ValorValorDeclarado&gt;
      &lt;EntregaDomiciliar&gt;<font class=value>string</font>&lt;/EntregaDomiciliar&gt;
      &lt;EntregaSabado&gt;<font class=value>string</font>&lt;/EntregaSabado&gt;
      &lt;Erro&gt;<font class=value>string</font>&lt;/Erro&gt;
      &lt;MsgErro&gt;<font class=value>string</font>&lt;/MsgErro&gt;
      &lt;ValorSemAdicionais&gt;<font class=value>string</font>&lt;/ValorSemAdicionais&gt;
      &lt;obsFim&gt;<font class=value>string</font>&lt;/obsFim&gt;
      &lt;DataMaxEntrega&gt;<font class=value>string</font>&lt;/DataMaxEntrega&gt;
      &lt;HoraMaxEntrega&gt;<font class=value>string</font>&lt;/HoraMaxEntrega&gt;
    &lt;/cServico&gt;
  &lt;/Servicos&gt;
&lt;/cResultado&gt;</pre>
          </span>

          <span>
              <h3>HTTP POST</h3>
              <p>The following is a sample HTTP POST request and response.  The <font class=value>placeholders</font> shown need to be replaced with actual values.</p>

              <pre>POST /calculador/calcprecoprazo.asmx/CalcPrecoPrazo HTTP/1.1
Host: ws.correios.com.br
Content-Type: application/x-www-form-urlencoded
Content-Length: <font class=value>length</font>

<font class=key>nCdEmpresa</font>=<font class=value>string</font>&amp;<font class=key>sDsSenha</font>=<font class=value>string</font>&amp;<font class=key>nCdServico</font>=<font class=value>string</font>&amp;<font class=key>sCepOrigem</font>=<font class=value>string</font>&amp;<font class=key>sCepDestino</font>=<font class=value>string</font>&amp;<font class=key>nVlPeso</font>=<font class=value>string</font>&amp;<font class=key>nCdFormato</font>=<font class=value>string</font>&amp;<font class=key>nVlComprimento</font>=<font class=value>string</font>&amp;<font class=key>nVlAltura</font>=<font class=value>string</font>&amp;<font class=key>nVlLargura</font>=<font class=value>string</font>&amp;<font class=key>nVlDiametro</font>=<font class=value>string</font>&amp;<font class=key>sCdMaoPropria</font>=<font class=value>string</font>&amp;<font class=key>nVlValorDeclarado</font>=<font class=value>string</font>&amp;<font class=key>sCdAvisoRecebimento</font>=<font class=value>string</font></pre>

              <pre>HTTP/1.1 200 OK
Content-Type: text/xml; charset=utf-8
Content-Length: <font class=value>length</font>

&lt;?xml version="1.0" encoding="utf-8"?&gt;
&lt;cResultado xmlns="http://tempuri.org/"&gt;
  &lt;Servicos&gt;
    &lt;cServico&gt;
      &lt;Codigo&gt;<font class=value>int</font>&lt;/Codigo&gt;
      &lt;Valor&gt;<font class=value>string</font>&lt;/Valor&gt;
      &lt;PrazoEntrega&gt;<font class=value>string</font>&lt;/PrazoEntrega&gt;
      &lt;ValorMaoPropria&gt;<font class=value>string</font>&lt;/ValorMaoPropria&gt;
      &lt;ValorAvisoRecebimento&gt;<font class=value>string</font>&lt;/ValorAvisoRecebimento&gt;
      &lt;ValorValorDeclarado&gt;<font class=value>string</font>&lt;/ValorValorDeclarado&gt;
      &lt;EntregaDomiciliar&gt;<font class=value>string</font>&lt;/EntregaDomiciliar&gt;
      &lt;EntregaSabado&gt;<font class=value>string</font>&lt;/EntregaSabado&gt;
      &lt;Erro&gt;<font class=value>string</font>&lt;/Erro&gt;
      &lt;MsgErro&gt;<font class=value>string</font>&lt;/MsgErro&gt;
      &lt;ValorSemAdicionais&gt;<font class=value>string</font>&lt;/ValorSemAdicionais&gt;
      &lt;obsFim&gt;<font class=value>string</font>&lt;/obsFim&gt;
      &lt;DataMaxEntrega&gt;<font class=value>string</font>&lt;/DataMaxEntrega&gt;
      &lt;HoraMaxEntrega&gt;<font class=value>string</font>&lt;/HoraMaxEntrega&gt;
    &lt;/cServico&gt;
    &lt;cServico&gt;
      &lt;Codigo&gt;<font class=value>int</font>&lt;/Codigo&gt;
      &lt;Valor&gt;<font class=value>string</font>&lt;/Valor&gt;
      &lt;PrazoEntrega&gt;<font class=value>string</font>&lt;/PrazoEntrega&gt;
      &lt;ValorMaoPropria&gt;<font class=value>string</font>&lt;/ValorMaoPropria&gt;
      &lt;ValorAvisoRecebimento&gt;<font class=value>string</font>&lt;/ValorAvisoRecebimento&gt;
      &lt;ValorValorDeclarado&gt;<font class=value>string</font>&lt;/ValorValorDeclarado&gt;
      &lt;EntregaDomiciliar&gt;<font class=value>string</font>&lt;/EntregaDomiciliar&gt;
      &lt;EntregaSabado&gt;<font class=value>string</font>&lt;/EntregaSabado&gt;
      &lt;Erro&gt;<font class=value>string</font>&lt;/Erro&gt;
      &lt;MsgErro&gt;<font class=value>string</font>&lt;/MsgErro&gt;
      &lt;ValorSemAdicionais&gt;<font class=value>string</font>&lt;/ValorSemAdicionais&gt;
      &lt;obsFim&gt;<font class=value>string</font>&lt;/obsFim&gt;
      &lt;DataMaxEntrega&gt;<font class=value>string</font>&lt;/DataMaxEntrega&gt;
      &lt;HoraMaxEntrega&gt;<font class=value>string</font>&lt;/HoraMaxEntrega&gt;
    &lt;/cServico&gt;
  &lt;/Servicos&gt;
&lt;/cResultado&gt;</pre>
          </span>

      </span>
      

    
    
      

      

    
  </body>
</html>
