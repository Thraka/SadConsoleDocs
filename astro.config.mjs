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
                      icon: 'open-book',
                      items: [
                          // Each item here is one entry in the navigation menu.
                          { label: 'Getting Started', slug: 'getting-started/cli' },
                          { label: 'Terminal demo', slug: 'guides/terminal-demo' },
                      ],
                  },
                  {
                      label: 'Advanced',
                      link: '/guides/how-to-use-imgui',
                      icon: 'open-book',
                      items: [
                          // Each item here is one entry in the navigation menu.
                          { label: 'How to use ImGui', slug: 'guides/how-to-use-imgui' },
                          { label: 'How to use the debugger', slug: 'guides/how-to-use-debugger' },
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
              ]),
          ],
      }),
	],

  markdown: {
      shikiConfig: {
          theme: 'nord',
      },
	},

  site: 'https://sadconsole.com'
});