
// 在web端调用unity函数
script.onload = () => {
    createUnityInstance(canvas, config, (progress) => {
      progressBarFull.style.width = 100 * progress + "%";
    }).then((unityInstance) => {
      loadingBar.style.display = "none";
      unityInstance.SendMessage('Main Camera', 'LoadWith', '100');
      document.getElementById("button2").onclick = function () { unityInstance.SendMessage('Main Camera', 'PlayAnimation'); };
    }).catch((message) => {
      alert(message);
    });
  };