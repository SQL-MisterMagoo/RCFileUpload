window.rcFileUpload = {
  loadFiles: function (e) {
    Array.from(e.files).forEach(f => {
      var reader = new FileReader();
      let currentFile = f.name;
      reader.addEventListener('load', async function () {
        await DotNet.invokeMethodAsync('RCFileUpload.App', 'LoadFile', currentFile, this.result);
        e.dispatchEvent(new Event('load'));
      }, false);
      reader.readAsDataURL(f);
    });

  }
}