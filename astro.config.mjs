// @ts-check
import { defineConfig } from 'astro/config';
import starlight from '@astrojs/starlight';
import astroExpressiveCode from 'astro-expressive-code'
import starlightSidebarTopics from 'starlight-sidebar-topics'
import starlightGitHubAlerts from 'starlight-github-alerts'


import netlify from '@astrojs/netlify';

// https://astro.build/config
export default defineConfig({
  integrations: [
      astroExpressiveCode({
          // Replace the default themes with a custom set of bundled themes:
          // "dracula" (a dark theme) and "solarized-light"
          themes: ['synthwave-84'],
          styleOverrides: {
              codeFontFamily: "DOS",
              codeFontSize: "1.0rem",
              codeLineHeight: "1.1"
          }
      }),
      starlight({
          title: 'SadConsole',
          logo: {
              src: '/src/assets/SadConsoleLogo.gif'
          },
          social: [
              { icon: 'discord', label: 'Discord', href: 'https://discord.gg/pAFNKYjczM' },
              { icon: 'github', label: 'GitHub', href: 'https://github.com/Thraka/SadConsole' }
          ],
          customCss: [
              './src/fonts/font-face.css',
              './src/styles/custom.css',
          ],
          plugins: [
              starlightGitHubAlerts(),
              starlightSidebarTopics([
                  {
                      label: 'Getting Started',
                      link: 'getting-started/cli',
                      icon: 'rocket',
                      items: [
                          // Each item here is one entry in the navigation menu.
                          { label: 'Getting Started with templates', slug: 'getting-started/cli' },
                          { label: 'Use Visual Studio', slug: 'getting-started/visualstudio' },
                      ],
                  },
                  {
                      label: 'Tutorials',
                      link: '/tutorials/first-game/part-1-drawing',
                      icon: 'open-book',
                      items: [
                        {
                            label: 'Your first SadConsole Game', items: [
                                // Each item here is one entry in the navigation menu.
                                { label: 'Part 1: Drawing', slug: 'tutorials/first-game/part-1-drawing' },
                                { label: 'Part 2: Cursors and parents', slug: 'tutorials/first-game/part-2-cursor-parents' },
                                { label: 'Part 3: Input', slug: 'tutorials/first-game/part-3-input' },
                                { label: 'Part 4: Game objects and maps', slug: 'tutorials/first-game/part-4-mapobject' },
                                { label: 'Part 5: More objects', slug: 'tutorials/first-game/part-5-more-objects' },
                            ]
                        }
                      ],
                  },
                  {
                      label: 'Concepts',
                      link: 'guides/host-overview',
                      icon: 'puzzle',
                      items: [
                        {
                            label: 'Game host', items: [
                                { label: 'Overview', slug: 'guides/host-overview' },
                                { label: 'Startup screen', slug: 'guides/host-screen' },
                            ]
                        },
                        {
                            label: 'Fonts', items: [
                                { label: 'Overview', slug: 'guides/fonts-overview' },
                            ]
                        },
                        {
                            label: 'Startup config', items: [
                                { label: 'Overview', slug: 'guides/config-overview' },
                            ]
                        },
                        {
                            label: 'Surfaces and Consoles', items: [
                                { label: 'Connect line glyphs', slug: 'guides/how-to-connect-lines' },
                            ]
                        },
                        {
                            label: 'String parser', items: [
                                { label: 'Overview', slug: 'guides/string-parser-overview' },
                                { label: 'Syntax reference', slug: 'guides/string-parser-syntax' },
                            ]
                        },
                        {
                            label: 'Controls', items: [
                                { label: 'Overview', slug: 'guides/controls-overview' },
                                { label: 'Change colors', slug: 'guides/how-to-change-control-colors' },
                            ]
                        },
                        {
                            label: 'ImGui and the Debugger', items: [
                                { label: 'How to use ImGui', slug: 'guides/how-to-use-imgui' },
                                { label: 'How to use the debugger', slug: 'guides/how-to-use-debugger' },
                            ]
                        },
                      ],
                  },
                  {
                      label: 'Reference',
                      link: '/reference/',
                      icon: 'information',
                      items: [
                          {
                              label: 'Reference',
                              //collapsed: true,
                              autogenerate: { directory: 'reference', collapsed: true },
                          },
                      ],
                  },
              ], { exclude: ['guides/terminal-demo/**'] }),
          ],
      }),
	],

  markdown: {
      shikiConfig: {
          theme: 'nord',
      },
	},

  image: {
    service: {
        entrypoint: './src/imageService.ts'
    }
  },

  site: 'https://sadconsole.com'
});