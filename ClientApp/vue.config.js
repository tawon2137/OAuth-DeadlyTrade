const webpack = require('webpack');
// vue.config.js
module.exports = {
    devServer: {
      progress: false
    },
    configureWebpack: {
      plugins: [
        new webpack.DefinePlugin({
          // 'BASE_URL': '"//www.naver.com"'
        })
      ]
    }
    
  }