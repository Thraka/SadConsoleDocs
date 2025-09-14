(function() {
  function init() {
    var body = document.body;
    var root = document.documentElement;
    var toggle = document.getElementById('crt-toggle');
    var range = document.getElementById('crt-range');
    var reset = document.getElementById('crt-reset');

    if (!toggle || !range || !reset) return;

    var savedEnabled = localStorage.getItem('crt-enabled');
    var savedIntensity = localStorage.getItem('crt-intensity');
    var intensity = savedIntensity !== null ? Number(savedIntensity) : 0.9;
    var enabled = savedEnabled === '1' || (savedEnabled === null && true); // default on

    // apply initial state
    root.style.setProperty('--crt-intensity', String(enabled ? intensity : 0));
    if (enabled) body.classList.add('crt-on'); else body.classList.remove('crt-on');

    // reflect in controls
    toggle.checked = enabled;
    range.value = String(intensity);

    toggle.addEventListener('change', function(e) {
      var on = e.target.checked;
      if (on) {
        body.classList.add('crt-on');
        root.style.setProperty('--crt-intensity', String(Number(range.value)));
        localStorage.setItem('crt-enabled', '1');
      } else {
        body.classList.remove('crt-on');
        root.style.setProperty('--crt-intensity', '0');
        localStorage.setItem('crt-enabled', '0');
      }
    });

    range.addEventListener('input', function(e) {
      var v = Number(e.target.value);
      root.style.setProperty('--crt-intensity', String(v));
      localStorage.setItem('crt-intensity', String(v));
    });

    reset.addEventListener('click', function() {
      localStorage.removeItem('crt-enabled');
      localStorage.removeItem('crt-intensity');
      root.style.setProperty('--crt-intensity', '0.9');
      body.classList.add('crt-on');
      toggle.checked = true;
      range.value = '0.9';
    });
  }

  if (document.readyState === 'loading') document.addEventListener('DOMContentLoaded', init);
  else init();
})();
