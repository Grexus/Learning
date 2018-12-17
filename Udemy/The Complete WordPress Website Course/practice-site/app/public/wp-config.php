<?php
/**
 * The base configuration for WordPress
 *
 * The wp-config.php creation script uses this file during the
 * installation. You don't have to use the web site, you can
 * copy this file to "wp-config.php" and fill in the values.
 *
 * This file contains the following configurations:
 *
 * * MySQL settings
 * * Secret keys
 * * Database table prefix
 * * ABSPATH
 *
 * @link https://codex.wordpress.org/Editing_wp-config.php
 *
 * @package WordPress
 */

// ** MySQL settings ** //
/** The name of the database for WordPress */
define( 'DB_NAME', 'local' );

/** MySQL database username */
define( 'DB_USER', 'root' );

/** MySQL database password */
define( 'DB_PASSWORD', 'root' );

/** MySQL hostname */
define( 'DB_HOST', 'localhost' );

/** Database Charset to use in creating database tables. */
define( 'DB_CHARSET', 'utf8' );

/** The Database Collate type. Don't change this if in doubt. */
define( 'DB_COLLATE', '' );

/**
 * Authentication Unique Keys and Salts.
 *
 * Change these to different unique phrases!
 * You can generate these using the {@link https://api.wordpress.org/secret-key/1.1/salt/ WordPress.org secret-key service}
 * You can change these at any point in time to invalidate all existing cookies. This will force all users to have to log in again.
 *
 * @since 2.6.0
 */
define('AUTH_KEY',         'yHMaxC567Z/92/vsEoCdnop3gKoCx3wbXQXiDw6L+M+gbQtBj9OXfJ9JMYz1kAhItdPiIPKQUB8bHJ4Jgas6tw==');
define('SECURE_AUTH_KEY',  'zsRXrQYB1nTlwwiqzoChbgp8IbmGyOIbsSZqeCmf6UXXY8UkPK/7l1DGJBli3yuoylBz/Ez3de40fFbsvFJPOQ==');
define('LOGGED_IN_KEY',    'SoZUwwAotENswYNwKIvIPpZ/Adi9s9xCmbuV/vq0iJEOGAbfT3z7WMWgIjCH+ZG95akmpNeb+H/LENO8KBYeRg==');
define('NONCE_KEY',        '1asLZ3CDNVuo64g6FhG9fuc65/RJxwwaHKGfY3149q7DYjQFhwNCj+QgKx61oZxzBtwKDWJOpc1VG7P5uFCO0Q==');
define('AUTH_SALT',        'xPtssnWjLMyLeXzNiR1hTizIZgn9k2BRQWwjGIXMBI8+d4KteppkwAQEkDvvhaTVe/itJ9DbUr7sQ+J+Fd+Xjg==');
define('SECURE_AUTH_SALT', '4plT95JkIsiRHVW9b9anmwjqZX/jbSmix51GlWnicuyRDFoN19CjQXowRVmLc8n7vgD2X34nR/3sJpArhAbmow==');
define('LOGGED_IN_SALT',   'qFfL7Iue0BNBJqVtiGr7/YnJL7Wd8LPEGb61Y+MQUM5EmMd7JmujTCL4rW6lmifGAmTRRb9NYGQSotOL64k67A==');
define('NONCE_SALT',       'WgeNvZdLy/pPdP34yGHuWxkFexhnC1J1ODmenLbtRXw6Yym+lZQjCEv6gzGHidJswl6Wc2OsDNocdgX5jvyDKQ==');

/**
 * WordPress Database Table prefix.
 *
 * You can have multiple installations in one database if you give each
 * a unique prefix. Only numbers, letters, and underscores please!
 */
$table_prefix = 'wp_';




/* That's all, stop editing! Happy blogging. */

/** Absolute path to the WordPress directory. */
if ( ! defined( 'ABSPATH' ) )
	define( 'ABSPATH', dirname( __FILE__ ) . '/' );

/** Sets up WordPress vars and included files. */
require_once ABSPATH . 'wp-settings.php';
