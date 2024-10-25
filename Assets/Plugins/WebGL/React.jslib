mergeInto(LibraryManager.library, {
  ButtonClicked: function (score) {
    window.dispatchReactUnityEvent("ButtonClicked", score);
  },
});
