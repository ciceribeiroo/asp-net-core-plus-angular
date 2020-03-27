const PROXY_CONFIG=[
{
    context:['/api'],
    target:'https://localhost:5007/',
    secure: true,
    logLevel: 'debug',
}];

module.exports  =PROXY_CONFIG;