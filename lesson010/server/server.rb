require 'json'
require 'pry'
require 'pry-byebug'
require 'sinatra'
require 'sinatra/reloader'
require 'sinatra/cross_origin'

enable :cross_origin

get '/hello' do
  # hoge.erb を 描画するときは，
  erb :hoge
end

get '/json' do
  cross_origin
  data = {
    board: [
      ['black', 'black', 'black'],
      ['black', 'black', 'black'],
      ['black', 'black', 'black'],
    ]
  }
  JSON.generate(data)
end
