module.exports = {
    module: {
      rules: [
        {
          test: /\.cs$/i,
          use: 'raw-loader',
        },
      ],
    },
  };