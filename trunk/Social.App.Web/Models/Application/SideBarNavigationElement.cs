﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Social.App.Web.Models.Application
{
    public class SideBarNavigationElement
    {
        public String URL { get; set; }
        public String Name { get; set; }
        public String Glyphicon { get; set; }
        public Boolean IsActive { get; set; }
    }
}
/*
 * GLYPHICON LIST 
 * 
 icon-glass
 icon-music
 icon-search
 icon-envelope
 icon-heart
 icon-star
 icon-star-empty
 icon-user
 icon-film
 icon-th-large
 icon-th
 icon-th-list
 icon-ok
 icon-remove
 icon-zoom-in
 icon-zoom-out
 icon-off
 icon-signal
 icon-cog
 icon-trash
 icon-home
 icon-file
 icon-time
 icon-road
 icon-download-alt
 icon-download
 icon-upload
 icon-inbox
 icon-play-circle
 icon-repeat
 icon-refresh
 icon-list-alt
 icon-lock
 icon-flag
 icon-headphones
 icon-volume-off
 icon-volume-down
 icon-volume-up
 icon-qrcode
 icon-barcode
 icon-tag
 icon-tags
 icon-book
 icon-bookmark
 icon-print
 icon-camera
 icon-font
 icon-bold
 icon-italic
 icon-text-height
 icon-text-width
 icon-align-left
 icon-align-center
 icon-align-right
 icon-align-justify
 icon-list
 icon-indent-left
 icon-indent-right
 icon-facetime-video
 icon-picture
 icon-pencil
 icon-map-marker
 icon-adjust
 icon-tint
 icon-edit
 icon-share
 icon-check
 icon-move
 icon-step-backward
 icon-fast-backward
 icon-backward
 icon-play
 icon-pause
 icon-stop
 icon-forward
 icon-fast-forward
 icon-step-forward
 icon-eject
 icon-chevron-left
 icon-chevron-right
 icon-plus-sign
 icon-minus-sign
 icon-remove-sign
 icon-ok-sign
 icon-question-sign
 icon-info-sign
 icon-screenshot
 icon-remove-circle
 icon-ok-circle
 icon-ban-circle
 icon-arrow-left
 icon-arrow-right
 icon-arrow-up
 icon-arrow-down
 icon-share-alt
 icon-resize-full
 icon-resize-small
 icon-plus
 icon-minus
 icon-asterisk
 icon-exclamation-sign
 icon-gift
 icon-leaf
 icon-fire
 icon-eye-open
 icon-eye-close
 icon-warning-sign
 icon-plane
 icon-calendar
 icon-random
 icon-comment
 icon-magnet
 icon-chevron-up
 icon-chevron-down
 icon-retweet
 icon-shopping-cart
 icon-folder-close
 icon-folder-open
 icon-resize-vertical
 icon-resize-horizontal
 icon-hdd
 icon-bullhorn
 icon-bell
 icon-certificate
 icon-thumbs-up
 icon-thumbs-down
 icon-hand-right
 icon-hand-left
 icon-hand-up
 icon-hand-down
 icon-circle-arrow-right
 icon-circle-arrow-left
 icon-circle-arrow-up
 icon-circle-arrow-down
 icon-globe
 icon-wrench
 icon-tasks
 icon-filter
 icon-briefcase
 icon-fullscreen
260 other icons still graciously provided by Glyphicons
 icon-glass
 icon-leaf
 icon-dog
 icon-user
 icon-girl
 icon-car
 icon-user-add
 icon-user-remove
 icon-film
 icon-magic
 icon-envelope
 icon-camera
 icon-heart
 icon-beach-umbrella
 icon-train
 icon-print
 icon-bin
 icon-trash
 icon-music
 icon-note
 icon-cogwheel
 icon-cog
 icon-home
 icon-snowflake
 icon-fire
 icon-cogwheels
 icon-parents
 icon-binoculars
 icon-road
 icon-search
 icon-cars
 icon-pencil
 icon-bus
 icon-wifi-alt
 icon-luggage
 icon-old-man
 icon-woman
 icon-file
 icon-credit
 icon-airplane
 icon-plane
 icon-notes
 icon-stats
 icon-charts
 icon-pie-chart
 icon-group
 icon-keys
 icon-calendar
 icon-router
 icon-camera-small
 icon-dislikes
 icon-star-empty
 icon-star
 icon-link
 icon-eye-open
 icon-eye-close
 icon-alarm
 icon-clock
 icon-time
 icon-stopwatch
 icon-projector
 icon-history
 icon-truck
 icon-cargo
 icon-compass
 icon-keynote
 icon-attach
 icon-power
 icon-off
 icon-lightbulb
 icon-tag
 icon-tags
 icon-cleaning
 icon-ruller
 icon-gift
 icon-umbrella
 icon-book
 icon-bookmark
 icon-signal
 icon-cup
 icon-stroller
 icon-headphones
 icon-headset
 icon-warning-sign
 icon-signal
 icon-retweet
 icon-refresh
 icon-roundabout
 icon-random
 icon-heat
 icon-repeat
 icon-display
 icon-log-book
 icon-adress-book
 icon-magnet
 icon-table
 icon-adjust
 icon-tint
 icon-crop
 icon-vector-path-square
 icon-vector-path-circle
 icon-vector-path-polygon
 icon-vector-path-line
 icon-vector-path-curve
 icon-vector-path-all
 icon-font
 icon-italic
 icon-bold
 icon-text-underline
 icon-text-strike
 icon-text-height
 icon-text-width
 icon-text-resize
 icon-left-indent
 icon-indent-left
 icon-right-indent
 icon-indent-right
 icon-align-left
 icon-align-center
 icon-align-right
 icon-justify
 icon-align-justify
 icon-list
 icon-text-smaller
 icon-text-bigger
 icon-embed
 icon-embed-close
 icon-adjust
 icon-message-full
 icon-message-empty
 icon-message-in
 icon-message-out
 icon-message-plus
 icon-message-minus
 icon-message-ban
 icon-message-flag
 icon-message-lock
 icon-message-new
 icon-inbox
 icon-inbox-plus
 icon-inbox-minus
 icon-inbox-lock
 icon-inbox-in
 icon-inbox-out
 icon-computer-locked
 icon-computer-service
 icon-computer-proces
 icon-phone
 icon-database-lock
 icon-database-plus
 icon-database-minus
 icon-database-ban
 icon-folder-open
 icon-folder-plus
 icon-folder-minus
 icon-folder-lock
 icon-folder-flag
 icon-folder-new
 icon-check
 icon-edit
 icon-new-window
 icon-more-windows
 icon-show-big-thumbnails
 icon-th-large
 icon-show-thumbnails
 icon-th
 icon-show-thumbnails-with-lines
 icon-th-list
 icon-show-lines
 icon-playlist
 icon-picture
 icon-imac
 icon-macbook
 icon-ipad
 icon-iphone
 icon-iphone-transfer
 icon-iphone-exchange
 icon-ipod
 icon-ipod-shuffle
 icon-ear-plugs
 icon-albums
 icon-step-backward
 icon-fast-backward
 icon-rewind
 icon-backward
 icon-play
 icon-pause
 icon-stop
 icon-forward
 icon-fast-forward
 icon-step-forward
 icon-eject
 icon-facetime-video
 icon-download-alt
 icon-mute
 icon-volume-off
 icon-volume-down
 icon-volume-up
 icon-screenshot
 icon-move
 icon-more
 icon-brightness-reduce
 icon-brightness-increase
 icon-circle-plus
 icon-plus-sign
 icon-circle-minus
 icon-minus-sign
 icon-circle-remove
 icon-remove-sign
 icon-circle-ok
 icon-ok-sign
 icon-circle-question-mark
 icon-question-sign
 icon-circle-info
 icon-info-sign
 icon-circle-exclamation-mark
 icon-exclamation-sign
 icon-remove
 icon-ok
 icon-ban
 icon-download
 icon-upload
 icon-shopping-cart
 icon-lock
 icon-unlock
 icon-electricity
 icon-cart-out
 icon-cart-in
 icon-left-arrow
 icon-right-arrow
 icon-down-arrow
 icon-up-arrow
 icon-resize-small
 icon-resize-full
 icon-circle-arrow-left
 icon-circle-arrow-right
 icon-circle-arrow-top
 icon-circle-arrow-up
 icon-circle-arrow-down
 icon-play-button
 icon-play-circle
 icon-unshare
 icon-share
 icon-thin-right-arrow
 icon-chevron-right
 icon-thin-arrow-left
 icon-chevron-left
 icon-bluetooth
 icon-euro
 icon-usd
 icon-bp
 icon-moon
 icon-sun
 icon-cloud
 icon-direction
 icon-brush
 icon-pen
 icon-zoom-in
 icon-zoom-out
 icon-pin
 icon-riflescope
 icon-rotation-lock
 icon-flash
 icon-google-maps
 icon-map-marker
 icon-anchor
 icon-conversation
 icon-chat
 icon-male
 icon-female
 icon-asterisk
 icon-divide
 icon-snorkel-diving
 icon-scuba-diving
 icon-oxygen-bottle
 icon-fins
 icon-fishes
 icon-boat
 icon-delete-point
 icon-qrcode
 icon-barcode
 icon-pool
 icon-buoy
 icon-spade
 icon-bank
 icon-vcard
 icon-electrical-plug
 icon-flag
 icon-credit-card
 icon-keyboard-wireless
 icon-keyboard-wired
 icon-shield
 icon-ring
 icon-cake
 icon-drink
 icon-beer
 icon-fast-food
 icon-cutlery
 icon-pizza
 icon-birthday-cake
 icon-tablet
 icon-settings
 icon-bullets
 icon-cardio
 icon-pants
 icon-sweater
 icon-fabric
 icon-leather
 icon-scissors
 icon-podium
 icon-skull
 icon-celebration
 icon-tea-kettle
 icon-french-press
 icon-coffe-cup
 icon-pot
 icon-grater
 icon-kettle
 icon-hospital
 icon-hospital-h
 icon-grater
 icon-kettle
 icon-hospital
 icon-hospital-h
 icon-microphone
 icon-webcam
 icon-temple-christianity-church
 icon-temple-islam
 icon-temple-hindu
 icon-temple-buddhist
 icon-electrical-socket-eu
 icon-electrical-socket-us
 icon-bomb
 icon-comment
 icon-comments
 icon-flower
 icon-baseball
 icon-rugby
 icon-ax
 icon-table-tennis
 icon-bowling
 icon-tree-conifer
 icon-tree-deciduous
 icon-sort
 icon-filter
 icon-gamepad
 icon-playing-dices
 icon-calculator
 icon-tie
 icon-wallet
 icon-share
 icon-sampler
 icon-piano
 icon-web-browser
 icon-blog
 icon-dashboard
 icon-certificate
 icon-bell
 icon-candle
 icon-pin-classic
 icon-iphone-shake
 icon-pin-flag
 icon-turtle
 icon-rabbit
 icon-globe
 icon-briefcase
 icon-hdd
 icon-thumbs-up
 icon-thumbs-down
 icon-hand-right
 icon-hand-left
 icon-hand-up
 icon-hand-down
 icon-fullscreen
 icon-shopping-bag
 icon-book-open
 icon-nameplate
 icon-nameplate-alt
 icon-vases
 icon-announcement
 icon-bullhorn
 icon-dumbbell
 icon-suitcase
 icon-file-import
 icon-file-export
 icon-pinterest
 icon-dropbox
 icon-jolicloud
 icon-yahoo
 icon-blogger
 icon-picasa
 icon-amazon
 icon-tumblr
 icon-wordpress
 icon-instapaper
 icon-evernote
 icon-xing
 icon-zootool
 icon-dribbble
 icon-deviantart
 icon-read-it-later
 icon-linked-in
 icon-forrst
 icon-pinboard
 icon-behance
 icon-github
 icon-youtube
 icon-skitch
 icon-quora
 icon-google-plus
 icon-spootify
 icon-stumbleupon
 icon-readability
 icon-facebook
 icon-twitter-t
 icon-twitter
 icon-buzz
 icon-vimeo
 icon-flickr
 icon-last-fm
 icon-rss
 icon-skype
 */