//click on the profile picture to change the background color of the page
document.querySelector('.profile').addEventListener('click', function () {
  document.body.style.backgroundColor = 'lightblue';
});

var typedKeys = '';
document.addEventListener('keydown', function (event) {
  typedKeys += event.key;

  if (typedKeys === '1337') {
    alert('You found the secret message! 🎉');

    typedKeys = '';
  }
});
