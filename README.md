<h1>Obfuscator JS – Una herramienta para obfuscar JS sin dependencias globales - VB.net + JS</h1>
<p>
	<img src="https://img.shields.io/badge/VB.NET-512BD4?logo=dotnet&logoColor=white&style=flat" alt="VB.NET" />
	<img src="https://img.shields.io/badge/Node.js-339933?logo=node.js&logoColor=white&style=flat" alt="Node.js" />
	<img src="https://img.shields.io/badge/JavaScript-F7DF1E?logo=javascript&logoColor=black&style=flat" alt="JavaScript" />
	<img src="https://img.shields.io/badge/licencia-Apache%202.0-green?style=flat-square" alt="Licencia: Apache 2.0">
</p>

<section>
  <img src="https://github.com/yosusanz/yosusanz/blob/main/images/obfuscatorJS/banner.png?raw=true" alt="Obfuscator JS" width="846"/>
  <p align="center">VB.NET | JS</p>
  <br>
  <p>Obfuscator JS es una herramienta escrita en VB.NET para ofuscar archivos JavaScript de forma automática y sin dependencias externas, utilizando Node.js portable y `javascript-obfuscator`.</p>
  <p>No es necesario preocuparse de dependencias ya que las instala la propia aplicación en su arranque.</p>
  <img src="https://github.com/yosusanz/yosusanz/blob/main/images/obfuscatorJS/screenshots.png?raw=true" alt="Obfuscator JS - pantalla splashscreen y aplicación" width="846"/>
  <br>
  <br>

  <br>
  <h2>🧠 Funcionalidad</h2>
	<ul>
		<li>Detecta si Node.js portable está instalado, si no, lo descarga y configura automáticamente.</li>
		<li>Genera el script `obfuscate.js` si no existe.</li>
		<li>Instala automáticamente el paquete `javascript-obfuscator` si es necesario. Ejecuta npm sin necesidad de instalación.</li>
		<li>Procesa todos los archivos `.js` de entrada, creando una copia ofuscada en el directorio de salida.</li>
	</ul>


  <h2>⚙️ Arquitectura</h2>
  <ul>
    <li>VB.NET WinForms</li>
    <li>Node.js portable embebido</li>
    <li>Sin dependencias externas, transparente al usuario</li>
  </ul>

  <br>
  <h2>🚀 Instalación y uso</h2>
	<p>Clona el repositorio</p>
	<p>Ejecuta el `.exe` generado o compila desde VB.NET</p>
	<ol>
		<li>Selecciona una carpeta con tus archivos `.js`.</li>
		<li>Selecciona una carpeta de salida.</li>
		<li>Ejecuta la obfuscación.</li>
		<li>La salida ofuscada se generará con su jerarquía en la carpeta de salida.</li>
	</ol>

  <br>
  <h2>🧩 Tecnologías usadas</h2>
  <ul>
    <li>VB.NET (.NET Framework)</li>
    <li>Node.js 20.14.0 portable</li>
    <li><a href="https://github.com/javascript-obfuscator/javascript-obfuscator">javascript-obfuscator</a></li>
  </ul>
  <p>Se utiliza exclusivamente Node.js v20.14.0 por compatibilidad garantizada.</p>
  <p>El script `npm-portable.bat` permite ejecutar `npm` sin necesidad de instalación global. Se crea automaticamente y es transparente al usuario.</p>


  <br>
  <h2>📄 Licencia</h2>
  <p>
    <strong>Apache License 2.0</strong> – puedes usar esta plantilla libremente en proyectos personales o comerciales.<br>
    Es <strong>obligatorio</strong> mantener el aviso de copyright, la licencia y cualquier nota de atribución.<br>
    Las modificaciones también deben incluir una <strong>nota explicando los cambios</strong> realizados.
  </p>

  <br>
  <p align="center"><i>Desarrollado por <a href="https://www.linkedin.com/in/yosusanz" target="_blank">@yosusanz</a> – más proyectos en mi perfil de <a href="https://github.com/yosusanz" target="_blank">GitHub</a></i></p>
</section>
