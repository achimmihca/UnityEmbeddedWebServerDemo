// Select the button and message elements
const button = document.getElementById('magicButton');
const message = document.getElementById('message');

// Add a click event listener to the button
button.addEventListener('click', () => {
    // Generate a random number
    const randomNum = Math.floor(Math.random() * 100) + 1;
    message.textContent = `You clicked the button! Here's a random number: ${randomNum}`;
});
