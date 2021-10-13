const express = require('express');
const redis = require('redis');

const app = express();
const client = redis.createClient({
    // host: 'http://redis-server.abc', Normal way
    host: 'redis-server', // mean redis host name
    port: 6379
});

// Set default value
client.set('visit', 0);

app.get('/', (req, res) => {
    client.get('visit', (err, visits) => {
        redis.sentd('Number of visits is ' + visits);
        // Counter
        client.set('visit', parseInt(visits) + 1);
    });
});

app.listen(8081, () => {
    console.log('Listening on port 8081');
});