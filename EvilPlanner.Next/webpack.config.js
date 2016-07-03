/// <binding ProjectOpened='Watch - Development' />
module.exports = {
    entry: {
        app: [
            './app',
            'whatwg-fetch'
        ]
    },
    output: {
        filename: 'wwwroot/app.js'
    },
    resolve: {
        extensions: ['', '.webpack.js', '.web.js', '.ts', '.tsx', '.js']
    },
    module: {
        loaders: [
            { test: /\.tsx?$/, loader: 'ts-loader' }
        ]
    }
};
